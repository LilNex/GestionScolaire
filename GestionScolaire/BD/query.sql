create table Etudiant(
	id_E int primary key identity,
	Nom_E varchar(100),
	Prenom_E varchar(100),
	Datenaissance_E date,
	NiveauScolaire_E int,
	Adresse_E varchar(100),
	Sexe_E varchar(100),
	Tel_E varchar(100),
	NomPere_E varchar(100),
	MetierPere_E varchar(100),
	TelPere_E varchar(100),
	NomMere_E varchar(100),
	MetierMere_E varchar(100),
	TelMere_E varchar(100)
)
create table Professeur(
	id_P int primary key identity,
	Nom_P varchar(100),
	Prenom_P varchar(100),
	Datenaissance_P date,
	NiveauScolaire_P int,
	Adresse_P varchar(100),	
	Tel_P varchar(100)
)
create table Classe(
    --Numero
	id_C int primary key identity,
	Etage_C int,
	Superficie_C varchar(100),
	Labo_C  varchar(100),
	TravauxPratique_C varchar(100),
	Bibliotheque_C varchar(100)
)
create table Matiere(
	id_M int primary key identity,
	Nom_M varchar(100),
	id_P int foreign key references Professeur(id_P),
	NumSalle_M int
)
create table Note(
	id_N int primary key identity,
	id_M int foreign key references Matiere (id_M),
	id_E int foreign key references Etudiant (id_E),
	NumControle_N int,
	Moyenne_N int
)
create table Avertissement(
	id_A int primary key identity,
    id_E int foreign key references Etudiant (id_E),
	Motif_A varchar(100),
	Severite_A int
)
create table Absence(
	id_Absence int primary key identity,
	Date_Absence date,
	Justifie_Absence varchar(100),
	--id_Cour
)
create table Documents(
	id_D int primary key identity,
	Nom_D varchar(100),
	Chemin_D varchar(100),
	DateDepot Date
)
create table Paiement(
	id_Pa int primary key identity,
    id_E int foreign key references Etudiant (id_E),
	Mois_Pa int,
	Annee_Pa int,
	DatePaiement_Pa date
)