using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppDevProj
{
    public partial class QuickView : Form
    {
        private CollectionsData _collectionsData = new CollectionsData();

        private readonly string _collectionsPath =
            Path.Combine(Application.StartupPath, "collections.json");

        private ContextMenuStrip _collectionsMenu;

        public QuickView()
        {
            InitializeComponent();

            this.Load += QuickView_Load;

            // right-click selection + menu
            QuickViewCollectionsListBox.MouseDown += QuickViewCollectionsListBox_MouseDown;

            // selection changes load items
            QuickViewCollectionsListBox.SelectedIndexChanged += QuickViewCollectionsListBox_SelectedIndexChanged;

            BuildCollectionsContextMenu();
        }

        private void QuickView_Load(object sender, EventArgs e)
        {
            LoadCollectionsFromJson();
            BindCollectionsToListBox();

            if (QuickViewCollectionsListBox.Items.Count > 0)
                QuickViewCollectionsListBox.SelectedIndex = 0;
        }

        private void BuildCollectionsContextMenu()
        {
            _collectionsMenu = new ContextMenuStrip();

            var addItem = new ToolStripMenuItem("Add Item...");
            addItem.Click += AddItem_Click;

            _collectionsMenu.Items.Add(addItem);

            // optional: attach to ListBox so it can also open via keyboard/menu key
            QuickViewCollectionsListBox.ContextMenuStrip = _collectionsMenu;
        }

        private void QuickViewCollectionsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            int index = QuickViewCollectionsListBox.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                QuickViewCollectionsListBox.SelectedIndex = index; // select the collection you right-clicked
                _collectionsMenu.Show(QuickViewCollectionsListBox, e.Location);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            var selectedCollection = QuickViewCollectionsListBox.SelectedItem as CollectionData;
            if (selectedCollection == null) return;

            using (var dlg = new AddItem())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                // Auto-generate an itemId like i5, i6, etc.
                string newId = GetNextItemId(_collectionsData);

                var newItem = new CollectionItem
                {
                    itemId = newId,
                    name = dlg.ItemName,
                    description = dlg.ItemDescription
                };

                selectedCollection.items.Add(newItem);

                SaveCollectionsToJson();

                // refresh listview to show the new item immediately
                LoadItemsIntoListView(selectedCollection);
            }
        }

        private string GetNextItemId(CollectionsData data)
        {
            // Finds max numeric part of iN across all collections and adds 1
            int max = 0;
            foreach (var c in data.collections)
            {
                foreach (var it in c.items)
                {
                    if (it.itemId != null && it.itemId.StartsWith("i"))
                    {
                        int n;
                        if (int.TryParse(it.itemId.Substring(1), out n))
                            if (n > max) max = n;
                    }
                }
            }
            return "i" + (max + 1);
        }

        private void LoadCollectionsFromJson()
        {
            try
            {
                if (!File.Exists(_collectionsPath))
                {
                    _collectionsData = new CollectionsData();
                    return;
                }

                string json = File.ReadAllText(_collectionsPath);
                _collectionsData = JsonConvert.DeserializeObject<CollectionsData>(json) ?? new CollectionsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load collections.json:\n" + ex.Message);
                _collectionsData = new CollectionsData();
            }
        }

        private void SaveCollectionsToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_collectionsData, Formatting.Indented);
                File.WriteAllText(_collectionsPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save collections.json:\n" + ex.Message);
            }
        }

        private void BindCollectionsToListBox()
        {
            QuickViewCollectionsListBox.DataSource = null;
            QuickViewCollectionsListBox.DataSource = _collectionsData.collections;
            QuickViewCollectionsListBox.DisplayMember = "title";
        }

        private void QuickViewCollectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCollection = QuickViewCollectionsListBox.SelectedItem as CollectionData;
            if (selectedCollection == null) return;

            LoadItemsIntoListView(selectedCollection);
        }

        private void LoadItemsIntoListView(CollectionData collection)
        {
            QuickviewCollectionListView.BeginUpdate();
            try
            {
                QuickviewCollectionListView.Items.Clear();
                QuickviewCollectionListView.Columns.Clear();

                QuickviewCollectionListView.View = View.Details;
                QuickviewCollectionListView.FullRowSelect = true;

                QuickviewCollectionListView.Columns.Add("ID", 80);
                QuickviewCollectionListView.Columns.Add("Name", 160);
                QuickviewCollectionListView.Columns.Add("Description", 220);

                foreach (var item in collection.items)
                {
                    var row = new ListViewItem(item.itemId);
                    row.SubItems.Add(item.name);
                    row.SubItems.Add(item.description);
                    QuickviewCollectionListView.Items.Add(row);
                }
            }
            finally
            {
                QuickviewCollectionListView.EndUpdate();
            }
        }

        private void QuickviewBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
        }
    }

    // --- Models matching your JSON exactly (lowercase property names) ---

    public class CollectionsData
    {
        public List<CollectionData> collections { get; set; } = new List<CollectionData>();
    }

    public class CollectionData
    {
        public string collectionId { get; set; }
        public string title { get; set; }
        public List<CollectionItem> items { get; set; } = new List<CollectionItem>();
    }

    public class CollectionItem
    {
        public string itemId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
