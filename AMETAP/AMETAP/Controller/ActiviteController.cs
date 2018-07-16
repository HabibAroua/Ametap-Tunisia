using System;
using System.Collections.Generic;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
using AMETAP.Controller.Script;
using System.Threading;

namespace AMETAP.Controller
{
    public class ActiviteController
    {
        private ActiviteDA aDA;
        private BudgetDA bDA;
        private AdherentDA adDA;
        private OrganisateurDA oDA;
        private BudgetCategorieDA bcDA;
        Activite a;

        public ActiviteController()
        {
            aDA = new ActiviteDA();
            bDA = new BudgetDA();
            adDA = new AdherentDA();

            oDA = new OrganisateurDA();
            bcDA = new BudgetCategorieDA();
        }

        public void AjouterActivite(String nom_activite, int capacite, String date_debut, String date_fin, double prix_unitaire, double montant_prevu, double montant_actuel, String categorie, String nomOrganisateur, String date_debut_inscription, String date_fin_inscription, int nbr_point)
        {
            DateValue dDebut = new DateValue(date_debut);
            DateValue dFin = new DateValue(date_fin);
            DateValue dDebutInscription = new DateValue(date_debut_inscription);
            DateValue dFinInscription = new DateValue(date_fin_inscription);

            if ((int.Parse(dDebut.getYear()) != bDA.LastYear()) || (int.Parse(dFin.getYear()) != bDA.LastYear()) || (int.Parse(dDebutInscription.getYear()) != bDA.LastYear()) || (int.Parse(dFinInscription.getYear()) != bDA.LastYear()))
            {
                MessageBox.Show("Nous sommes en " + bDA.LastYear() + " ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime debut = new DateTime(int.Parse(dDebut.getYear()), int.Parse(dDebut.getMonth()), int.Parse(dDebut.getDay()));
                DateTime fin = new DateTime(int.Parse(dFin.getYear()), int.Parse(dFin.getMonth()), int.Parse(dFin.getDay()));
                DateTime debutInscription = new DateTime(int.Parse(dDebutInscription.getYear()), int.Parse(dDebutInscription.getMonth()), int.Parse(dDebutInscription.getDay()));
                DateTime finInscription = new DateTime(int.Parse(dFinInscription.getYear()), int.Parse(dFinInscription.getMonth()), int.Parse(dFinInscription.getDay()));
                int r1 = DateTime.Compare(debut, fin);
                int r2 = DateTime.Compare(debutInscription, finInscription);
                int r3 = DateTime.Compare(finInscription, debut);
                if (r1 != -1)
                {
                    MessageBox.Show("La date de début d'activité doit être antérieur que la date fin d'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (r2 != -1)
                    {
                        MessageBox.Show("La date de début d'inscription doit être antérieur que la date fin d'inscription", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (r3 != -1)
                        {
                            MessageBox.Show("La date de fin d'inscription doit être antérieur que la date début d'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            a = new Activite(0, nom_activite, capacite, 0, date_debut, date_fin, prix_unitaire, montant_prevu, montant_actuel, getIdBudgetCat(categorie), oDA.findIdByNomOrganisateur(nomOrganisateur), date_debut_inscription, date_fin_inscription, nbr_point);
                            Boolean test = aDA.insert(a);
                            if (test == true)
                            {
                                Thread thread = new Thread(() => mailing(nom_activite, date_debut, date_fin));
                                thread.Start();
                                MessageBox.Show("L'ajout d'une activité effectué avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(" Erreur ! Vérifiez les valeurs des champs", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        public void findActivityByYear(DataGridView d, String objet)
        {
            d.DataSource = aDA.search(objet);
        }

        public void mailing(String nom_activite, String date_debut, String date_fin)
        {
            List<String> listAdresse = adDA.listAdresse();
            foreach (String a in listAdresse)
            {
                Mailing m;
                m = new Script.Mailing(a, "Nouvelle Activité :" + nom_activite, "L'AMETAP informe tous les adhérents que nous allons organiser une nouvelle activité qui'elle sera a " + date_debut + " jusqu'à " + date_fin + " ");
                m.sendMail();
            }
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

        public void ModifierActivite(int idActivite, String nom_activite, String date_fin_inscription, String date_debut, String date_fin, int capacite, double prix_unitaire, double montant_prevu, int nombre_point, String categorie)
        {
            DateValue dDebut = new DateValue(date_debut);
            DateValue dFin = new DateValue(date_fin);
            DateValue dFinInscription = new DateValue(date_fin_inscription);
            DateTime debut = new DateTime(int.Parse(dDebut.getYear()), int.Parse(dDebut.getMonth()), int.Parse(dDebut.getDay()));
            DateTime fin = new DateTime(int.Parse(dFin.getYear()), int.Parse(dFin.getMonth()), int.Parse(dFin.getDay()));
            DateTime finInscription = new DateTime(int.Parse(dFinInscription.getYear()), int.Parse(dFinInscription.getMonth()), int.Parse(dFinInscription.getDay()));
            int r1 = DateTime.Compare(debut, fin);
            int r3 = DateTime.Compare(finInscription, debut);
            if (r1 != -1)
            {
                MessageBox.Show("La date de début d'activité doit être plus tard que la date fin d'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (r3 != -1)
                {
                    MessageBox.Show("La date de fin d'inscription doit être plus tard que la date début d'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BudgetCategorie bc = bcDA.getBudgetCategorieByIdActivite(idActivite);
                    Boolean Test = aDA.ModifierActivite(idActivite, nom_activite, capacite, date_fin_inscription, date_debut, date_fin, prix_unitaire, montant_prevu, nombre_point, getIdBudgetCat(categorie), aDA.findMontantPrevuById(idActivite), bc.id);
                    if (Test == true)
                    {
                        MessageBox.Show("La modification de cette activité est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        public void AfficherActivite(DataGridView d)
        {
            d.DataSource = aDA.sellectAll();
        }

        public void AfficheInformation(DataGridView d, String annee)
        {
            d.DataSource = aDA.selectInformation(annee);
        }

        public List<Activite> StatCulturel(String annee)
        {
            return aDA.selectNomActiviteCulturel(annee);
        }

        public List<Activite> StatLoisir(String annee)
        {
            return aDA.selectNomActiviteLoisir(annee);
        }
        public void calculerMontant_prevu(String capacite, String prix_unitaire, String montant_prevu)
        {
            if ((capacite.Equals("")) || (prix_unitaire.Equals("")))
            {
                montant_prevu = "";
            }
            else
            {
                montant_prevu = "" + (double.Parse(prix_unitaire) / 2) * int.Parse(capacite);
            }
        }

        public int getIdBudgetCat(String categorie)
        {
            return aDA.getId(categorie, bDA.LastYear());
        }

        public int totalMontant_prevuLoisir(String annee)
        {
            return aDA.sumMontant_prevuLoisir(annee);
        }

        public int totalMontant_prevuCulturel(String annee)
        {
            return aDA.sumMontant_prevuCulturel(annee);
        }

        public void ActiviteActuel(DataGridView d)
        {
            d.DataSource = aDA.activiteActuel();
        }

        public void getActuelActivity(DataGridView d)
        {
            d.DataSource = aDA.getActuelleActivty();
        }

        public int getNombreActiviteActuel()
        {
            return aDA.getNombreActiviteActuel();
        }
    }
}
