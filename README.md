# GoogleSearchTest

Un projet de test automatisé en C# utilisant **Selenium WebDriver** et **NUnit**. Ce dépôt montre comment configurer et exécuter des tests automatisés pour vérifier la fonctionnalité de recherche sur Google.

---

## Caractéristiques principales

- **Langage :** C#
- **Frameworks utilisés :**
  - **Selenium WebDriver** : Pour l'automatisation des actions dans le navigateur.
  - **NUnit** : Pour écrire et exécuter des tests.
- **Structure organisée :**
  - **`Init`** : Gestion des configurations (WebDriver, paramètres).
  - **`TestCases`** : Scénarios de tests.
- **Prise en charge des navigateurs :** Tests avec Google Chrome via **ChromeDriver**.

---

## Installation

### Prérequis

1. Installez le [SDK .NET](https://dotnet.microsoft.com/).
2. Installez Google Chrome.

### Étapes

1. Clonez ce dépôt :
   ```bash
   git clone https://github.com/karima2022/GoogleSearchTest.git
   cd GoogleSearchTest
   ```
2. Restaurez les packages nécessaires :
   ```bash
   dotnet restore
   ```

---

## Exécution des tests

1. Construisez le projet :
   ```bash
   dotnet build
   ```
2. Lancez les tests :
   ```bash
   dotnet test
   ```

---

## Exemple de scénario testé

1. Accéder à Google.
2. Taper une requête dans le champ de recherche.
3. Vérifier que des résultats sont affichés.

---

## Structure du projet

```plaintext
GoogleSearchTest/
├── Init/
│   └── DriverSetup.cs          # Configuration du WebDriver
├── TestCases/
│   └── GoogleSearchTests.cs    # Tests de recherche Google
├── GoogleSearchTest.csproj     # Fichier de configuration du projet
└── README.md                   # Documentation du projet
```







