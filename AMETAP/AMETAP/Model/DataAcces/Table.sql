CREATE TABLE  "ACTIVITE" 
(	
    "ID" NUMBER(*,0), 
	"NOM_ACTIVITE" VARCHAR2(200), 
	"CAPACITE" NUMBER(*,0), 
	"NOMBRE_PARTICIPANT" NUMBER(*,0), 
	"DATE_DEBUT" DATE, 
	"DATE_FIN" DATE, 
	"PRIX_UINITAIRE" NUMBER(*,0), 
	"MONTANT_PREVU" NUMBER(*,0), 
	"MONTANT_ACTUEL" NUMBER(*,0), 
	"IDBUDGETCAT" NUMBER(*,0), 
	"IDORGANISATEUR" NUMBER(*,0), 
	"DATE_DEBUT_INSCRIPTION" DATE, 
	"DATE_FIN_INSCRIPTION" DATE, 
	"NBR_POINT" NUMBER, 
	CONSTRAINT "CHECK_DATE_FIN" CHECK (Date_fin >= Date_debut) ENABLE, 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("IDBUDGETCAT")
	REFERENCES  "BUDGETCATEGORIE" ("ID") ENABLE, 
	FOREIGN KEY ("IDORGANISATEUR")
	REFERENCES  "ORGANISATEUR" ("ID") ENABLE
);

CREATE TABLE  "ADHERENT" 
(	
    "MATRICULEETAP" NUMBER(*,0), 
	"MATRICULEAMETAP" NUMBER(*,0), 
	"LOGIN" VARCHAR2(100), 
	"PASSWORD" VARCHAR2(800), 
	"NOMBRE_POINT" NUMBER(*,0), 
	 PRIMARY KEY ("MATRICULEETAP") ENABLE, 
	 UNIQUE ("MATRICULEAMETAP") ENABLE, 
	 UNIQUE ("LOGIN") ENABLE, 
	 FOREIGN KEY ("MATRICULEETAP")
	  REFERENCES  "PERSONNEL" ("MATRICULE") ENABLE, 
	 FOREIGN KEY ("MATRICULEAMETAP")
	  REFERENCES  "PARTICIPANT" ("MATRICULE") ENABLE
);

CREATE TABLE  "ADMIN" 
(	
    "MATRICULE" NUMBER(*,0), 
	"LOGIN" VARCHAR2(50), 
	"PASSWORD" VARCHAR2(650), 
	"ESTADMIN" VARCHAR2(4000), 
	PRIMARY KEY ("MATRICULE") ENABLE, 
	UNIQUE ("LOGIN") ENABLE, 
	FOREIGN KEY ("MATRICULE")
	REFERENCES  "PERSONNEL" ("MATRICULE") ENABLE
);

CREATE TABLE  "AGENCE_VOYAGE" 
(	
    "ID" NUMBER(*,0), 
	"DESCRIPTION" VARCHAR2(200), 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("ID")
	REFERENCES  "ORGANISATEUR" ("ID") ENABLE
);

CREATE TABLE  "BUDGET" 
(	
    "ID" NUMBER(*,0), 
	"ANNEE" NUMBER(*,0), 
	"BUDGET_ACTUEL" NUMBER(*,0), 
	"BUDGET_ACCRDE" NUMBER(*,0), 
	PRIMARY KEY ("ID") ENABLE, 
	UNIQUE ("ANNEE") ENABLE
);

CREATE TABLE  "BUDGETCATEGORIE" 
(	
    "ID" NUMBER(*,0), 
	"MONTANT" NUMBER(*,0) NOT NULL ENABLE, 
	"CATEGORIE" VARCHAR2(30), 
	"IDBUDGET" NUMBER, 
	"PROVISOIRE" NUMBER, 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("IDBUDGET")
	REFERENCES  "BUDGET" ("ID") ENABLE
);


CREATE TABLE  "CENTRE" 
(	
    "ID" NUMBER(*,0), 
	"DESCRIPTION" VARCHAR2(200), 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("ID")
	REFERENCES  "ORGANISATEUR" ("ID") ENABLE
);

CREATE TABLE  "CLUB" 
(	
    "ID" NUMBER(*,0), 
	"DESCRIPTION" VARCHAR2(200), 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("ID")
	REFERENCES  "ORGANISATEUR" ("ID") ENABLE
);

CREATE TABLE  "CONJOINT" 
(	
    "CIN" NUMBER(*,0), 
	"NOM" VARCHAR2(200) NOT NULL ENABLE, 
	"PRENOM" VARCHAR2(200) NOT NULL ENABLE, 
	"DATE_NAISSANCE" DATE NOT NULL ENABLE, 
	"METIER" VARCHAR2(200), 
	"MATRICULE" NUMBER(*,0), 
	PRIMARY KEY ("CIN") ENABLE, 
	FOREIGN KEY ("MATRICULE")
	REFERENCES  "ADHERENT" ("MATRICULEAMETAP") ENABLE, 
	FOREIGN KEY ("CIN")
	REFERENCES  "PARTICIPANT" ("MATRICULE") ENABLE
);

CREATE TABLE  "CONTRIBUES" 
(	
    "ID" NUMBER(*,0), 
	"MENSUALITE" DATE, 
	"MONTANT" NUMBER(*,0), 
	"MATRICULE" NUMBER(*,0), 
	"IDBUDGET" NUMBER(*,0), 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("MATRICULE")
	REFERENCES  "ADHERENT" ("MATRICULEETAP") ENABLE, 
	FOREIGN KEY ("IDBUDGET")
	REFERENCES  "BUDGET" ("ID") ENABLE
);

CREATE TABLE  "ENFANT" 
(	
    "ID" NUMBER(*,0), 
	"NOM" VARCHAR2(200) NOT NULL ENABLE, 
	"PRENOM" VARCHAR2(200) NOT NULL ENABLE, 
	"DATE_NAISSANCE" DATE NOT NULL ENABLE, 
	"ECOLE" VARCHAR2(200), 
	"MATRICULE" NUMBER(*,0), 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("MATRICULE")
	REFERENCES  "ADHERENT" ("MATRICULEAMETAP") ENABLE, 
	FOREIGN KEY ("ID")
	REFERENCES  "PARTICIPANT" ("MATRICULE") ENABLE
);

CREATE TABLE  "NATURE_AGENT" 
(					
	"ID_NATURAGENT" NUMBER(*,0), 
	"DESCRIPTION" VARCHAR2(80), 
	 PRIMARY KEY ("ID_NATURAGENT") ENABLE
);

CREATE TABLE  "ORGANISATEUR" 
(	
    "ID" NUMBER(*,0), 
	"NOM_ORGANISATEUR" VARCHAR2(50), 
	"EMAIL" VARCHAR2(50), 
	"ADRESSE" VARCHAR2(50), 
	PRIMARY KEY ("ID") ENABLE, 
	UNIQUE ("NOM_ORGANISATEUR") ENABLE
);

CREATE TABLE  "PARTICIPANT" 
(	
    "MATRICULE" NUMBER(*,0), 
	"DATE_INSC" DATE, 
	PRIMARY KEY ("MATRICULE") ENABLE
 );

CREATE TABLE  "PARTICIPATION" 
(	
    "ID" NUMBER(*,0), 
	"DATEDEMANDE" DATE, 
	"ETAT" NUMBER(*,0), 
	"NOTIF" VARCHAR2(90), 
	"IDACTIVITE" NUMBER(*,0), 
	"MATRICULEPART" NUMBER(*,0), 
	"ETATPAYAIMENT" NUMBER, 
	PRIMARY KEY ("ID") ENABLE, 
	FOREIGN KEY ("MATRICULEPART")
	REFERENCES  "PARTICIPANT" ("MATRICULE") ENABLE, 
	FOREIGN KEY ("IDACTIVITE")
	REFERENCES  "ACTIVITE" ("ID") ENABLE
);

CREATE TABLE  "PAYAIMENT" 
(	
    "ID" NUMBER(*,0), 
	"ETAT" VARCHAR2(50), 
	"IDPARTICIPATION" NUMBER(*,0), 
	PRIMARY KEY ("ID") ENABLE
);


CREATE TABLE  "PERSONNEL" 
(	
    "MATRICULE" NUMBER(*,0), 
	"NOM" VARCHAR2(50), 
	"PRENOM" VARCHAR2(50), 
	"ID_NATURAGENT" NUMBER(*,0), 
	"CODE_FONC" NUMBER(*,0), 
	"PERS_CET" NUMBER(*,0), 
	"SEX" VARCHAR2(2), 
	"ETAT_CIVIL" VARCHAR2(2), 
	"NBR_ENFANT" NUMBER(*,0), 
	"DATE_NAISSAINCE" DATE, 
	"LIEU" VARCHAR2(20), 
	"CIN" VARCHAR2(15), 
	"ADRESSE" VARCHAR2(80), 
	"TEL" VARCHAR2(10), 
	"DATE_RECRUTEMENT" DATE, 
	"PERS_CATPERS" NUMBER(*,0), 
	"PERS_AFFECT" VARCHAR2(5), 
	"OCCUPATION" VARCHAR2(30), 
	"CODE_BANQUE" NUMBER(*,0), 
	"CODE_AGENCE" NUMBER(*,0), 
	"NUMERO_COMPTE" NUMBER(*,0), 
	"EMAIL" VARCHAR2(30), 
	PRIMARY KEY ("MATRICULE") ENABLE, 
	UNIQUE ("CIN") ENABLE, 
	FOREIGN KEY ("ID_NATURAGENT")
	REFERENCES  "NATURE_AGENT" ("ID_NATURAGENT") ENABLE
);
