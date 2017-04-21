using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Activite
    {
        public int id
        {
            get;
            set;
        }

        public String nom_Activite
        {
            get;
            set;
        }

        public int capacite
        {
            get;
            set;
        }

        public int nombre_participant
        {
            get;
            set;
        }

        public String date_debut
        {
            get;
            set;
        }

        public String date_fin
        {
            get;
            set;
        }

        public double prix_unitaire
        {
            get;
            set;
        }

        public double montant_prevu
        {
            get;
            set;
        }

        public double montant_actuel
        {
            get;
            set;
        }

        public int idBudgetCategorie
        {
            get;
            set;
        }

        public int idOrganisateur
        {
            get;
            set;
        }
        public Activite()
        {

        }
        public Activite(int id, String nom_Activite , int capacite 
            , int nombre_participant , String date_debut,String  date_fin  ,double prix_unitaire ,
            double montant_prevu , double montant_actuel , int idBudgetCategorie, int idOrganisateur)
        {
            this.id = id;
            this.nom_Activite = nom_Activite;
            this.capacite = capacite;
            this.nombre_participant = nombre_participant;
            this.date_debut = date_debut;
            this.date_fin = date_fin;
            this.prix_unitaire = prix_unitaire;
            this.montant_prevu = montant_prevu;
            this.montant_actuel = montant_actuel;
            this.idBudgetCategorie = idBudgetCategorie;
            this.idOrganisateur = idOrganisateur;
        }

        public Activite(int id,double montant_prevu)
        {
            this.id = id;
            this.montant_prevu = montant_prevu;
        }



        public Activite(String nom_Activite, int capacite, int idOrganisateur)
        {
            this.nom_Activite = nom_Activite;
            this.capacite = capacite;
            this.idOrganisateur = idOrganisateur;
        }

        public Activite(String nom_Activite, double montant_prevu)
        {
            this.nom_Activite = nom_Activite;
            this.montant_prevu = montant_prevu;
        }
    }
}
