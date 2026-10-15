# Remax - Système d'administration

Salut! 👋

Ceci est mon projet de session pour le cours **Applications multi-tiers** (420-DA3-AS) au Collège LaSalle. C'est une application Windows en C# pour un courtier immobilier comme Remax : elle sert à gérer les agents, les clients et les maisons.

C'est un projet d'école, donc je ne prétends pas que c'est parfait. J'ai surtout essayé de bien comprendre comment séparer une application en couches, et j'ai appris beaucoup en le faisant.

## C'est quoi, l'idée?

Le but était de faire une application pour une agence immobilière où :

- **L'administrateur** a accès à tout : il gère les employés (admins et agents), les maisons et les clients (acheteurs et vendeurs).
- **Un agent** gère seulement ses propres clients (acheteurs et vendeurs) et ses propres maisons.
- **N'importe quel utilisateur** peut chercher une maison (par numéro de référence) ou un agent (par numéro d'employé).

## Comment c'est organisé

Le projet est une application client-serveur en trois couches. C'est la partie que j'ai trouvée la plus intéressante :

| Couche | Ce qu'elle fait |
|---|---|
| **GUI** | L'interface Windows Forms en C# (formulaires MDI et sous-formulaires), avec des couleurs et des images de Remax pour que ça ait l'air d'une vraie application |
| **Business** | Une bibliothèque de classes pour les entités : Société, Employés (Admin ou Agent), Clients (Acheteur ou Vendeur) et Maisons |
| **Data** | Une classe qui s'occupe de la base de données avec ADO.NET et qui passe les données à la couche Business (et dans l'autre sens) |

Dans la couche Business, j'ai utilisé les concepts de programmation orientée objet vus en classe : l'héritage (par exemple Admin et Agent qui héritent de Employé), la composition, l'agrégation et l'encapsulation.

## Ce que j'ai utilisé

- C# et Windows Forms
- Programmation orientée objet
- ADO.NET pour parler à la base de données
- Une base de données pour stocker les employés, les clients et les maisons
- Visual Studio

## Comment le lancer

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/AymaneNa/NOM_DU_DEPOT.git
   ```
2. Ouvrir le fichier `.sln` avec Visual Studio.
3. Vérifier la chaîne de connexion à la base de données (elle dépend de l'endroit où le fichier se trouve sur votre ordinateur).
4. Lancer le projet avec `F5`.

> Si ça ne démarre pas, c'est probablement la connexion à la base de données. C'est le problème que j'ai eu le plus souvent.

## Ce que j'ai appris

- Séparer le code en couches rend les choses plus claires, mais ça demande de bien réfléchir avant de commencer.
- L'héritage est pratique, mais il faut bien choisir quoi mettre dans la classe parent.
- Faire parler le code avec une vraie base de données, c'est différent de travailler avec des listes en mémoire.

## Ce que je pourrais améliorer

- Ajouter plus de validations dans les formulaires
- Améliorer l'apparence de l'interface
- Gérer mieux les erreurs de connexion à la base de données

## À propos de moi

Je m'appelle Aymane, j'étudie en programmation au Collège LaSalle et je termine mon DEC cette année. Je suis à la recherche de mes premières expériences en développement, alors n'hésitez pas à regarder mes autres projets ou à m'écrire!

GitHub : [AymaneNa](https://github.com/AymaneNa)
