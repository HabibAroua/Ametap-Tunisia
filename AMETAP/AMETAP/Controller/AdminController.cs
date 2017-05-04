using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMETAP.Model.DataAcces;
using AMETAP.Model.Business;
using AMETAP.View;
namespace AMETAP.Controller
{
    public class AdminController
    {
        AdminDA ad;
        public AdminController()
        {
            ad = new AdminDA();
        }
        public void Inscrire(int matricule,String login,String password)
        {
            Personnel p=new Personnel();
            p.matricule = matricule;
            Admin a = new Admin(p, login, password);
            Boolean test= ad.insert(a);
            if(test==true)
            {
                MessageBox.Show("Inscription effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Matricule ou login est existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean Connecter(String login , String password)
        {
            try
            {
                Boolean test = false;
                Admin a = ad.Verif(login);
                AMETAP.View.Script.Cryptage c = new View.Script.Cryptage();
                if ((a.login.Equals(login)) && (c.Descrypt(a.password).Equals(password)))
                {
                    test = true ;
                }
                return test;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vérifier votre login ou votre mot de passe", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void afficher(DataGridView d)
        {
            d.DataSource = ad.sellectAll();
        }

        public void rechercher(String ch, DataGridView d)
        {
            d.DataSource = ad.search(ch);
        }

        public void supprimer(int matricule)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer cet utilisateur ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Boolean test = ad.delete(matricule);
                if (test == true)
                {
                    MessageBox.Show("La suppression de cet utilisateur est effectué avec succés !", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur de suppression", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vous annulez cette suppression !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
