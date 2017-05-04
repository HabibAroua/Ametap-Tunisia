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
    public class OrganisateurController
    {
        CentreController cec;
        Agence_VoyageController avc;
        ClubController cc;
        OrganisateurDA oDA;
        public OrganisateurController()
        {
            cec = new CentreController();
            avc = new Agence_VoyageController();
            cc = new ClubController();
            oDA = new OrganisateurDA();

        }
        public void AjouterOrganisateur(String type, int id, String nom, String email, String adresse, String description)
        {
            id = oDA.maxID();
            Boolean test = false;
            switch (type)
            {
                case "Club":
                    test = oDA.insert(new Organisateur(id+1, nom, email, adresse));
                    if (test == true)
                    {
                        ClubController cc = new ClubController();
                        cc.ajouterClub(id + 1, description);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de l'insetion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Agence de voyage":
                    test = oDA.insert(new Organisateur(id + 1, nom, email, adresse));
                    if (test == true)
                    {
                        Agence_VoyageController avc = new Agence_VoyageController();
                        avc.AjouterAgence_Voyage(id + 1, description);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de l'insetion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Centre":
                    test = oDA.insert(new Organisateur(id + 1, nom, email, adresse));
                    if (test == true)
                    {
                        cec.AjouterCentre(id+ 1, description);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de l'insetion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default: return;

            }
        }

        public void affiche(DataGridView d)
        {
            OrganisateurDA oDA = new OrganisateurDA();
            d.DataSource = oDA.sellectAll();
        }

        public void supprimerOrganisateur(int id)
        {
            Boolean test1 = false;
            Boolean test2 = false;
            Boolean test3 = false;
            test1 = avc.isDeleted(id);
            test2 = cec.isDeleted(id);
            test3 = cc.isDeleted(id);
            if (test1 == true)
            {
                MessageBox.Show("Cet organisateur est déjà supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (test2 == true)
                {
                    MessageBox.Show("Cet organisateur est déjà supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (test3 == true)
                    {
                        MessageBox.Show("Cet organisateur est déjà supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        public void recherche(DataGridView d, String recherche)
        {
            OrganisateurDA oDA;
            oDA = new OrganisateurDA();
            d.DataSource = oDA.search(recherche);
        }

        public void modifier(int id, String nom, String email, String adresse, String description)
        {
            Boolean test1 = false;
            Boolean test2 = false;
            Boolean test3 = false;
            //test1 = avc.isUpdated(id, nom, email, adresse, description);
            test2 = cec.isUpdated(id, nom, email, adresse, description);
            test3 = cc.isUpdated(id, nom, email, adresse, description);
            if (test1 == true)
            {
                MessageBox.Show("La mise à jour de cet organisateur est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (test2 == true)
                {
                    MessageBox.Show("La mise à jour de cet organisateur est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (test3 == true)
                    {
                        MessageBox.Show("La mise à jour de cet organisateur est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de la mise à jour", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        public List<Organisateur>AllOrganisateur()
        {
            return oDA.AllOrganisateur();
        }
    }
}
    

