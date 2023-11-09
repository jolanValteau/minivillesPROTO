#region Init

using minivillesPROTO;

Paquet.modelesCartes.Add((1, 1, "Bleu", "Champs de blé", "Recevez 1 pièce", 1));
Paquet.modelesCartes.Add((2, 1, "Bleu", "Ferme", "Recevez 1 pièce", 2));
Paquet.modelesCartes.Add((3, 2, "Vert", "Boulangerie", "Recevez 2 pièces", 1));
Paquet.modelesCartes.Add((4, 3, "Rouge", "Café", "Recevez 1 pièce du joueur qui a lancé le dé", 2));
Paquet.modelesCartes.Add((5, 4, "Vert", "Superette", "Recevez 3 pièces", 2));
Paquet.modelesCartes.Add((6, 5, "Bleu", "Forêt", "Recevez 1 pièce", 2));
Paquet.modelesCartes.Add((7, 5, "Rouge", "Restaurant", "Recevez 2 pièces du joueur qui a lancé le dé", 4));
Paquet.modelesCartes.Add((8, 6, "Bleu", "Stade", "Recevez 4 pièce", 6));
#endregion

Paquet pqt1 = new();
pqt1.Debug();