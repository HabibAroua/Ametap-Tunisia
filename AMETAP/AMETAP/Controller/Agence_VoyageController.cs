using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
namespace AMETAP.Controller
{
    public class Agence_VoyageController
    {
        Agence_VoyageDA avDA;
        Agence_Voyage av;
        public Agence_VoyageController()
        {
            avDA = new Agence_VoyageDA();
        }
        
        public void AjouterAgence_Voyage(int id,String description)
        {
             av = new Agence_Voyage(id, description);
             
            Boolean test = avDA.insert(av);
            if (test == true)
            {
                MessageBox.Show("L'ajout effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de l'insertion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void affiche(DataGridView d)
        {
            Agence_VoyageDA aDA = new Agence_VoyageDA();
            d.DataSource = aDA.sellectAll();
        }

        public Boolean isDeleted(int id)
        {
            return avDA.delete(id);
        }

        public Boolean isUpdated(int id, String nom, String email, String adresse, String description)
        {
            return avDA.update(new Organisateur(id, nom, email, adresse), new Agence_Voyage(id, description));
        }
    }
}
