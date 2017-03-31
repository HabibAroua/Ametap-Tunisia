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

        public double montant
        {
            get;
            set;
        }

        public double prix_unitaire
        {
            get;
            set;
        }

        public Activite()
        {

        }
        public Activite(int id, String nom_Activite , int capacite 
            , int nombre_participant , String date_debut,String  date_fin ,double montant ,double prix_unitaire)
        {
            this.id = id;
            this.nom_Activite = nom_Activite;
            this.capacite = capacite;
            this.nombre_participant = nombre_participant;
            this.date_debut = date_debut;
            this.date_fin = date_fin;
            this.montant = montant;
            this.prix_unitaire = prix_unitaire;
        }
    }
}
