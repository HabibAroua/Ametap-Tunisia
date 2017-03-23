using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;

namespace AMETAP.Controller
{
    public class ClubController
    {
        ClubDA cDA;
        Club c;
        
        public ClubController()
        {
            cDA = new ClubDA();
        }

        public void ajouterClub(int id,String description)
        {
            c = new Club(id, description);
            cDA = new ClubDA();
            Boolean test= cDA.insert(c);
            if(test==true)
            {
                MessageBox.Show("L'insertion de cette organisation est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de l'insertion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void affiche(DataGridView d)
        {
            d.DataSource = cDA.sellectAll();
        }

        public Boolean isDeleted(int id)
        {
            return cDA.delete(id);
        }

        public Boolean isUpdated(int id,String nom,String email,String adresse,String description)
        {
            return cDA.update(new Organisateur(id, nom, email, adresse), new Club(id, description));
        }
    }
}
