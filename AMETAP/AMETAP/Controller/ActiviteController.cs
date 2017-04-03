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
        TypeActiviteDA taDA;
        OrganisateurDA oDA;
        Activite a;
        public ActiviteController()
        {
            aDA = new ActiviteDA();
            bDA = new BudgetDA();
            taDA = new TypeActiviteDA();
            oDA = new OrganisateurDA();
        }

        public void AjouterActivite(String nom_activite, int capacite, String date_debut, String date_fin,double prix_unitaire, double montant_prevu, double montant_actuel, String typeActivite ,String nomOrganisateur)
        {
            a = new Activite(0, nom_activite, capacite,0 ,date_debut, date_fin,prix_unitaire, montant_prevu, montant_actuel, taDA.findIdByLibelle(typeActivite), bDA.findIdByLastYear(),oDA.findIdByNomOrganisateur(nomOrganisateur));
            Boolean test = aDA.insert(a);
            if(test==true)
            {
                MessageBox.Show("Congrulation!! Vous ajoutez une nouvelle activité", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vous avez un erreur au niveau de l'insertion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findActivityByYear(DataGridView d,String objet)
        {
            d.DataSource = aDA.search(objet);
        }

        public void SupprimerActivite(int id,double montant_prevu)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer cette activité ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Boolean test = aDA.delete(new Activite(id, montant_prevu));
                if(test==true)
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
    }
}
