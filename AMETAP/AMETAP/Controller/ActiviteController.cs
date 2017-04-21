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
    public class ActiviteController
    {
        ActiviteDA aDA;
        BudgetDA bDA;
        //TypeActiviteDA taDA;
        OrganisateurDA oDA;
        Activite a;
        public ActiviteController()
        {
            aDA = new ActiviteDA();
            bDA = new BudgetDA();
          //  taDA = new TypeActiviteDA();
            oDA = new OrganisateurDA();
        }

        public void AjouterActivite(String nom_activite, int capacite, String date_debut, String date_fin, double prix_unitaire, double montant_prevu, double montant_actuel, String categorie, String nomOrganisateur)
        {
            a = new Activite(0, nom_activite, capacite, 0, date_debut, date_fin, prix_unitaire, montant_prevu, montant_actuel, getIdBudgetCat(categorie), oDA.findIdByNomOrganisateur(nomOrganisateur));
            Boolean test = aDA.insert(a);
            if (test == true)
            {
                MessageBox.Show("Congrulation!! Vous ajoutez une nouvelle activité", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vous avez un erreur au niveau de l'insertion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findActivityByYear(DataGridView d, String objet)
        {
            d.DataSource = aDA.search(objet);
        }

        public void SupprimerActivite(int id, double montant_prevu)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer cette activité ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Boolean test = aDA.delete(new Activite(id, montant_prevu));
                if (test == true)
                {
                    MessageBox.Show("La suppresion de cette activité est effectué avec sucéss !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur de suppresion !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous annulez cette suppression !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ModifierActivite(int id, String nomActivite, int capacite, String typeActivite, String organisateur)
        {
            
        }

        public void AfficherActivite(DataGridView d)
        {
            d.DataSource = aDA.sellectAll();
        }

        public void AfficheInformation(DataGridView d, String annee)
        {
            d.DataSource = aDA.selectInformation(annee);
        }

        public List<Activite> Stat(String annee)
        {
            return aDA.selectNomActivite(annee);
        }

        public void calculerMontant_prevu(String capacite,String prix_unitaire,String montant_prevu)
        {
            if((capacite.Equals(""))||(prix_unitaire.Equals("")))
            {
                montant_prevu = "";
            }
            else
            {
                montant_prevu = "" + (double.Parse(prix_unitaire) / 2) * int.Parse(capacite);
            }
        }

        public int getIdBudgetCat(String categorie )
        {
            return aDA.getId(categorie,bDA.LastYear() );
        }

    }
}
