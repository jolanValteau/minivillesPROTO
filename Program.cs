using minivillesPROTO;
// id, valueActivation, color, name, description, priceCard, money giving, money taking
Paquet.templatesCards.Add((1, 1, "Bleu", "Champs de blé","Recevez 1 pièce", 1, 1, 0));
Paquet.templatesCards.Add((2, 1, "Bleu", "Ferme",        "Recevez 1 pièce", 2, 1, 0));
Paquet.templatesCards.Add((3, 2, "Vert", "Boulangerie",  "Recevez 2 pièces", 1, 2, 0));
Paquet.templatesCards.Add((4, 3, "Rouge","Café",         "Recevez 1 pièce du joueur qui a lancé le dé", 2, 0, 1));
Paquet.templatesCards.Add((5, 4, "Vert", "Superette",    "Recevez 3 pièces", 2, 3, 0));
Paquet.templatesCards.Add((6, 5, "Bleu", "Forêt",        "Recevez 1 pièce", 2, 1, 0));
Paquet.templatesCards.Add((7, 5, "Rouge","Restaurant",   "Recevez 2 pièces du joueur qui a lancé le dé", 4, 0, 2));
Paquet.templatesCards.Add((8, 6, "Bleu", "Stade",        "Recevez 4 pièce", 6, 4, 0));

Jeu jeu = new(2);
jeu.SetupGame();
while (true)
{
    jeu.Turn();
}