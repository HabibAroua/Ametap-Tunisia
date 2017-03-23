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
        public OrganisateurController()
        {
            cec = new CentreController();
            avc = new Agence_VoyageController();
            cc = new ClubController();

        }
        public void AjouterOrganisateur(String type, int id, String nom, String email, String adresse, String description)
        {
            OrganisateurDA oDA;
            Boolean test = false;
            switch (type)
            {
                case "Club":
                    oDA = new OrganisateurDA();
                    test = oDA.insert(new Organisateur(id, nom, email, adresse));
                    if (test == true)
                    {
                        ClubController cc = new ClubController();
                        cc.ajouterClub(id, description);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de l'insetion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Agence de voyage":
                    oDA = new OrganisateurDA();
                    test = oDA.insert(new Organisateur(id, nom, email, adresse));
                    if (test == true)
                    {
                        Agence_VoyageController avc = new Agence_VoyageController();
                        avc.AjouterAgence_Voyage(id, description);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de l'insetion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Centre":
                    oDA = new OrganisateurDA();
                    test = oDA.insert(new Organisateur(id, nom, email, adresse));
                    if (test == true)
                    {
                        CentreController cec = new CentreController();
                        cec.AjouterCentre(id, description);
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
                MessageBox.Show("Cet organisateur est déjà modifié", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (test2 == true)
                {
                    MessageBox.Show("Cet organisateur est déjà modifié", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (test3 == true)
                    {
                        MessageBox.Show("Cet organisateur est déjà modifié", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}
    

