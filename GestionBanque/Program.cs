using GestionBanque.Models;

//Personne p1 = new Personne();
//p1.Nom = "Pendragon";
//p1.Prenom = "Arthur";
//p1.DateNaiss = DateTime.Now;

//Courant c1 = new Courant();
//c1.Numero = "BE1234";
//c1.Titulaire = p1;
//c1.Depot(500);

//Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

//c1.Retrait(200);
//Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
//c1.Retrait(500);
//Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

//c1.LigneDeCredit = 500;
//c1.Retrait(1000);
//Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");


//Banque maBanque = new Banque();


//maBanque.Ajouter(c1);

//Sur base du numéro de compte je doit retrouver le nom de la banque

//Console.WriteLine($"{maBanque["BE1234"].Nom}");

//Banque amoi = new Banque();
//amoi.AjouterPersonne(p2);
//amoi.AjouterPersonne(p1);

//Console.WriteLine($"Numero de telephone de Loic :{amoi["Loic"].NumTel}");

Personne p1 = new Personne();
p1.Nom = "Pendragon";
p1.Prenom = "Arthur";
p1.DateNaiss = DateTime.Now;

Courant c1 = new Courant();
c1.Numero = "BE1234";
c1.Titulaire = p1;
c1.Depot(500);

Banque bque = new();
bque.Nom = "CBC";
bque.AjouterCompte(c1);



Console.WriteLine(bque["BE1234"]?.Titulaire.Nom ?? "la ref est null");

bque.SupprimerCompte(c1);

Console.WriteLine(bque["BE1234"]?.Titulaire.Nom ?? "la ref est null");