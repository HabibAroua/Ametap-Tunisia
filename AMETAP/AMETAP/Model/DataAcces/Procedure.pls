create or replace PROCEDURE AccepterDemandeAdherent(a_matricule IN Adherent.MATRICULEETAP%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE) 
IS BEGIN 
	update Participation set etat=1 , Notif='Vous etes le bienvenue , vous devez payer' where MATRICULEPART=a_matricule and idActivite=a_idActivite ;
	COMMIT ; 
END;

create or replace PROCEDURE AccepterDemandeConjoint(c_cin IN Conjoint.cin%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE)
IS BEGIN 
	update Participation set etat=1 , Notif='Vous etes le bienvenue pour votre conjoint , vous devez payer' where MATRICULEPART=c_cin and idActivite=a_idActivite ; 
	COMMIT ; 
END;

create or replace PROCEDURE AccepterDemandeEnfant(e_id IN Enfant.id%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE)
IS BEGIN 
	update Participation set etat=1 , Notif='Vous etes le bienvenue pour votre enfant, vous devez payer' where MATRICULEPART=e_id and idActivite=a_idActivite ; 
	COMMIT ; 
END;

create or replace PROCEDURE AjouterActivite(a_Nom_Activite IN Activite.Nom_Activite%TYPE , a_capacite IN Activite.capacite%TYPE , a_date_debut IN Activite.date_debut%TYPE ,a_date_fin IN Activite.date_fin%TYPE , a_prix_unitaire IN Activite.PRIX_UINITAIRE%TYPE , a_montant_prevu IN Activite.montant_prevu%TYPE ,a_montant_actuel IN Activite.montant_actuel%TYPE , a_idBudgetCat IN Activite.IDBUDGETCAT%TYPE , a_idOrganisateur IN Activite.idOrganisateur%TYPE ,a_date_debut_insctiption IN Activite.date_debut_inscription%TYPE , a_date_fin_inscription IN Activite.date_fin_inscription%TYPE ,a_nbr_point IN Activite.NBR_POINT%TYPE)
IS BEGIN 
	insert into Activite values ( activite_auto_incr.nextval, a_Nom_Activite, a_capacite , 0 , a_date_debut , a_date_fin ,a_prix_unitaire,a_montant_prevu ,a_montant_actuel,a_idBudgetCat,a_idOrganisateur,a_date_debut_insctiption , a_date_fin_inscription,a_nbr_point); 
	COMMIT ; 
	update BudgetCategorie set PROVISOIRE=PROVISOIRE-a_montant_prevu where id=a_idBudgetCat; 
	COMMIT ; 
END;

create or replace PROCEDURE ConfPayerAdherent(a_matricule IN Adherent.MATRICULEETAP%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE)
IS BEGIN
	update Activite set Nombre_Participant=Nombre_Participant+1 where id=a_idActivite ;
	COMMIT ; 
	update Participation set ETATPAYAIMENT=1 , Notif='Activité payer' where MATRICULEPART=a_matricule and idActivite=a_idActivite ; 
	COMMIT ; 
	update adherent set Nombre_Point=Nombre_Point-a_nombre_Point where matriculeEtap=a_matricule ; 
	COMMIT; 
END;

create or replace PROCEDURE ConfPayerConjoint(c_cin IN Conjoint.cin%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE)
IS BEGIN 
	update Activite set Nombre_Participant=Nombre_Participant+1 where id=a_idActivite ;
	COMMIT ;
	update Participation set ETATPAYAIMENT=1 , Notif='Activite payer' where MATRICULEPART=c_cin and idActivite=a_idActivite ;
	COMMIT ; 
	update adherent set Nombre_Point=Nombre_Point-a_nombre_Point where matriculeEtap=(select matricule from Conjoint where cin=c_cin) ;
	COMMIT;	
END;

create or replace PROCEDURE ConfPayerEnfant(e_id IN Enfant.id%TYPE , a_idActivite IN Activite.id%TYPE , p_id IN Participation.id%TYPE , a_nombre_Point IN Adherent.Nombre_Point%TYPE) 
IS BEGIN 
	update Activite set Nombre_Participant=Nombre_Participant+1 where id=a_idActivite ; 
	COMMIT ; 
	update Participation set ETATPAYAIMENT=1 , Notif='Activite payer' where MATRICULEPART=e_id and idActivite=a_idActivite ; 
	COMMIT ; 
	update adherent set Nombre_Point=Nombre_Point-a_nombre_Point where matriculeEtap=(select matricule from Enfant where id=e_id) ; 
	COMMIT; 
END;

create or replace PROCEDURE FixerBudget(b_id IN Budget.id%TYPE , b_annee IN Budget.annee%TYPE , b_montant_provisoire IN Budget.BUDGET_ACTUEL%TYPE , b_montant_final IN Budget.BUDGET_ACCRDE%TYPE , b_montantCat1 IN BudgetCategorie.montant%TYPE , b_montantCat2 IN BudgetCategorie.montant%TYPE) 
IS BEGIN
	insert into Budget values ( b_id, b_annee, b_montant_provisoire , b_montant_final); 
	COMMIT ; 
	insert into BudgetCategorie values (budgetCat_auto_incr.nextval , b_montantCat1 ,'Activité culturel',b_id , b_montantCat1); 
	COMMIT; 
	insert into BudgetCategorie values (budgetCat_auto_incr.nextval , b_montantCat2 ,'Activité de loisir',b_id , b_montantCat2); 
	COMMIT; 
END;

create or replace PROCEDURE Inscrire ( c_matricule IN admin.matricule%TYPE, c_login IN admin.login%TYPE, c_password IN admin.password%TYPE) 
IS BEGIN 
	INSERT INTO admin VALUES (c_matricule,c_login,c_password,'F'); 
	COMMIT; 
END;

create or replace PROCEDURE ModifierActivite(a_id IN Activite.id%TYPE , a_nomActivite IN Activite.nom_activite%TYPE,a_capacite IN Activite.capacite%TYPE,a_date_fin_inscription IN Activite.date_fin_inscription%TYPE,a_date_debut IN Activite.date_debut%TYPE , a_date_fin IN Activite.date_fin%TYPE ,a_prix_unitaire IN Activite.PRIX_UINITAIRE%TYPE ,a_montant_prevu IN Activite.MONTANT_PREVU%TYPE , a_nbr_point IN Activite.NBR_POINT%TYPE, a_idBudgetCat IN Activite.IDBUDGETCAT%TYPE,b_provisoire_ajouter IN budgetCategorie.PROVISOIRE%TYPE,b_id IN budgetCategorie.ID%TYPE)
IS BEGIN 
	update budgetCategorie set provisoire=provisoire+b_provisoire_ajouter where id=b_id; 
	COMMIT ; 
	update Activite set NOM_ACTIVITE=a_nomActivite , CAPACITE=a_capacite , date_fin_inscription=a_date_fin_inscription , date_debut=a_date_debut , date_fin=a_date_fin , PRIX_UINITAIRE=a_prix_unitaire , MONTANT_PREVU=a_montant_prevu , MONTANT_ACTUEL=a_montant_prevu ,NBR_POINT=a_nbr_point ,idBudgetCat=a_idBudgetCat where id=a_id; 
	COMMIT; 
	update budgetCategorie set provisoire=provisoire-a_montant_prevu where id=a_idBudgetCat; 
	COMMIT; 
END;

create or replace PROCEDURE ModifierAgence (o_id IN Organisateur.id%TYPE , o_nomOrganisateur IN Organisateur.nom_organisateur%type , o_email IN Organisateur.email%TYPE , o_adresse IN Organisateur.adresse%TYPE , a_description IN Agence_Voyage .description%TYPE ) 
IS BEGIN 
	update Organisateur set Nom_Organisateur=o_nomOrganisateur , Email=o_email , ADRESSE=o_adresse where id=o_id ; 
	COMMIT; 
	update Agence_Voyage set Agence_Voyage.description=a_description where Agence_Voyage.id=o_id ; 
	COMMIT;
END;

create or replace PROCEDURE ModifierCentre (o_id IN Organisateur.id%TYPE , o_nomOrganisateur IN Organisateur.nom_organisateur%type , o_email IN Organisateur.email%TYPE , o_adresse IN Organisateur.adresse%TYPE , a_description IN Centre .description%TYPE ) 
IS BEGIN 
	update Organisateur set Nom_Organisateur=o_nomOrganisateur , Email=o_email , ADRESSE=o_adresse where id=o_id ; 
	COMMIT; 
	update Centre set Centre.description=a_description where Centre.id=o_id ; 
	COMMIT;
END;

create or replace PROCEDURE ModifierClub (o_id IN Organisateur.id%TYPE , o_nomOrganisateur IN Organisateur.nom_organisateur%type , o_email IN Organisateur.email%TYPE , o_adresse IN Organisateur.adresse%TYPE , a_description IN Club .description%TYPE ) 
IS BEGIN 
	update Organisateur set Nom_Organisateur=o_nomOrganisateur , Email=o_email , ADRESSE=o_adresse where id=o_id ; 
	COMMIT; 
	update Club set Club.description=a_description where Club.id=o_id ; 
	COMMIT; 
END;

create or replace PROCEDURE RefuserDemandeAdherent(p_id IN Participation.id%TYPE) 
IS BEGIN 
	update Participation set etat=-1 , Notif='Vous etes refuse' Where id=p_id ; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerActivite(a_id IN Activite.Nom_Activite%TYPE , a_montant_prevu IN Activite.Montant_prevu%TYPE) 
IS BEGIN 
	update BudgetCategorie set PROVISOIRE=PROVISOIRE+a_montant_prevu where id=(select IDBUDGETCAT from Activite where IDBUDGETCAT=a_id); 
	COMMIT ; 
	delete participation where idActivite=a_id; 
	COMMIT; 
	delete Activite where id=a_id ; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerAdherent(a_matricule IN Adherent.matriculeEtap%TYPE) 
IS BEGIN 
	delete Contribues where matricule=a_matricule ; 
	COMMIT; 
	delete Adherent where matriculeAmetap=a_matricule ; 
	COMMIT ; 
END;

create or replace PROCEDURE SupprimerAdmin(a_matricule IN Admin.matricule%TYPE) 
IS BEGIN 
	delete Admin where matricule=a_matricule ; 
	COMMIT ; 
END;

create or replace PROCEDURE SupprimerAgence (o_id IN Organisateur.id%TYPE)
IS BEGIN 
	delete Agence_Voyage where id=o_id ; 
	COMMIT; 
	delete Organisateur where id=o_id; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerCentre (o_id IN Organisateur.id%TYPE) 
IS BEGIN 
	delete Centre where id=o_id ; 
	COMMIT; 
	delete Organisateur where id=o_id; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerClub (o_id IN Organisateur.id%TYPE) 
IS BEGIN 
	delete Club where id=o_id ; 
	COMMIT; 
	delete Organisateur where id=o_id; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerOrganisateur(o_id IN Organisateur.id%TYPE) 
IS BEGIN 
	delete Centre where id=o_id ; 
	COMMIT; 
	delete Agence_Voyage where id=o_id; 
	COMMIT; 
	delete Club where id=o_id; COMMIT; 
	delete Organisateur where id=o_id; 
	COMMIT; 
END;

create or replace PROCEDURE SupprimerParticipant (p_matricule IN Participant.matricule%TYPE) 
IS BEGIN
	delete Participant where matricule=p_matricule ; 
	COMMIT; 
END;
