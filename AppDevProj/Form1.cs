using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDevProj
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            ThemeComboBox.SelectedIndex = 0;
            LanguageComboBox.SelectedIndex = 0;
        }

        private void ContinueAsGuestLinkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
            this.Hide();
        }

        private void ContinueAsGuestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
            this.Hide();
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LanguageComboBox.SelectedItem == "English")
            {
                LoginLabel.Text = "LOGIN";
                LoginLabel.Location = new Point(107, 27);
                UsernameLabel.Text = "Username";
                PasswordLabel.Text = "Password";
                LoginButton.Text = "LOGIN";
                ContinueAsGuestLinkLabel.Text = "Don't feel like it? Continue as guest";

                RegisterButton.Text = "REGISTER";
                RegisterLabel.Text = "REGISTER";
                RegisterUsernameLabel.Text = "Username";
                PasswordRegisterLabel.Text = "Password";
                ContinueAsGuestLinkLabelRegister.Text = "Don't feel like it? Continue as guest";
            } 
            else if(LanguageComboBox.SelectedItem == "Francais")
            {
                LoginLabel.Text = "CONNEXION";
                LoginLabel.Location = new Point(60,27);
                UsernameLabel.Text = "Identifiant";
                PasswordLabel.Text = "Mot de passe";
                LoginButton.Text = "CONNEXION";
                ContinueAsGuestLinkLabel.Text = "Pas envie ? Continuez en tant qu’invité !";

                RegisterLabel.Text = "INSCRIPTION";
                RegisterLabel.Location = new Point(50, 27);
                RegisterUsernameLabel.Text = "Identifiant";
                PasswordRegisterLabel.Text = "Mot de passe";
                RegisterButton.Text = "S'INSCRIRE";
                ContinueAsGuestLinkLabelRegister.Text = "Pas envie ? Continuez en tant qu’invité !";

            }
            else if( LanguageComboBox.SelectedItem == "Espanol")
            {
                LoginLabel.Text = "INICIAR SESION";
                LoginLabel.Location = new Point(30, 27);
                UsernameLabel.Text = "Identificación";
                PasswordLabel.Text = "Contraseña";
                LoginButton.Text = "INICIAR SESION";
                ContinueAsGuestLinkLabel.Text = "¿No te apetece? Continúa como invitado";

                RegisterLabel.Text = "REGISTRAR";
                RegisterUsernameLabel.Text = "Identificación";
                PasswordRegisterLabel.Text = "Contraseña";
                RegisterButton.Text = "REGISTRAR";
                ContinueAsGuestLinkLabelRegister.Text = "¿No te apetece? Continúa como invitado";
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThemeComboBox.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.White;
                    LoginLabel.ForeColor = Color.Black;
                    UsernameLabel.ForeColor = Color.Black;
                    PasswordLabel.ForeColor = Color.Black;
                    LoginButton.ForeColor = Color.Black;

                    RegisterLabel.ForeColor = Color.Black;
                    RegisterUsernameLabel.ForeColor = Color.Black;
                    PasswordRegisterLabel.ForeColor = Color.Black;
                    RegisterButton.ForeColor = Color.Black;

                    LoginTab.BackColor = Color.White;
                    RegisterTab.BackColor = Color.White;
                    ContinueAsGuestLinkLabel.LinkColor = Color.Blue;
                    ContinueAsGuestLinkLabelRegister.LinkColor = Color.Blue;
                    break;
                case 1:
                    this.BackColor = Color.Black;
                    LoginLabel.ForeColor = Color.White;
                    UsernameLabel.ForeColor = Color.White;
                    PasswordLabel.ForeColor = Color.White;
                    
                    

                    RegisterLabel.ForeColor = Color.White;
                    RegisterUsernameLabel.ForeColor = Color.White;
                    PasswordRegisterLabel.ForeColor = Color.White;
                    

                    LoginTab.BackColor = Color.Black;
                    RegisterTab.BackColor = Color.Black;
                    ContinueAsGuestLinkLabel.LinkColor = Color.Cyan;
                    ContinueAsGuestLinkLabelRegister.LinkColor = Color.Cyan;
                    break;
            }
        }
    }
}
