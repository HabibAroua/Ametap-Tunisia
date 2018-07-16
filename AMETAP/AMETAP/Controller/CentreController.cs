using System;
using System.Windows.Forms;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;

namespace AMETAP.Controller
{
    public class CentreController
    {
        CentreDA cDA;
        Centre c;
        public CentreController()
        {
            cDA = new CentreDA();
        }

        public void AjouterCentre(int id,String description)
        {
            c = new Centre(id, description);
            cDA = new CentreDA();
            Boolean test = cDA.insert(c);
            if(test==true)
            {
                MessageBox.Show("L'ajout de cette organisation est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de l'insertion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void affiche(DataGridView d)
        {
            cDA = new CentreDA();
            d.DataSource = cDA.sellectAll();
        }

        public Boolean isDeleted(int id)
        {
            return cDA.delete(id);
        }

        public Boolean isUpdated(int id, String nom, String email, String adresse, String description)
        {
            return cDA.update(new Organisateur(id, nom, email, adresse), new Centre(id, description));
        }
    }
}
