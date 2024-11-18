namespace CestQuoiTonType
{
    internal class Program
    {
        public struct Adresse
        {
            public int noPorte;
            public string rue;
            public string ville;
            public string province;
            public string pays;
            public string codePostal;
        }

        public struct Date
        {
            public int jour;
            public int mois;
            public int annee;
        }

        public struct Etudiant
        {
            public string nom;
            public string prenom;
            public string numDA;
            public Adresse adresse;
            public Date dateNaissance;
            public Date dateInscription;
            public string[] cours;
        }

        static string DecrireAdresse(Adresse a)
        {   // Pas besoin de comprendre le code, regardez seulement la signature
            return $"{a.noPorte} {a.rue} {a.ville} {a.province} {a.pays} {a.codePostal.ToUpper()}";
        }

        static long UnixTimeStamp(Date date)
        {   // Pas besoin de comprendre le code, regardez seulement la signature
            DateTime d = new(year: date.annee, month: date.mois, day: date.jour);
            DateTime unix = new(year: 1970, month: 1, day: 1);
            return (long)Math.Round((d - unix).TotalSeconds);
        }

        static void Main(string[] _)
        {
            Adresse alma = new Adresse
            {
                noPorte = 123,
                rue = "des Ormes",
                ville = "Alma",
                province = "Québec",
                pays = "Canada",
                codePostal = "G6E3R4"
            };


            Date naissance = new Date
            {
                jour = 21,
                mois = 4,
                annee = 2006
            };

            Etudiant fernand = new Etudiant
            {
                nom = "Fernand",
                numDA = "1234567",
                adresse = alma,
                dateNaissance = naissance,
                dateInscription = new Date
                {
                    jour = 15,
                    mois = 3,
                    annee = 2024
                },
                cours = ["Programmation 1", "Philo", "Plongée"]
            };

            int[] score = [84, 71, 59];

            // DÉBUT
            // Trouvez le type de chaque expression suivant l'égalité
            var a = 51;     // Réponse : int
            var b = score;  // Réponse : int[]
            var c = score[0];
            var d = score.Length;

            var e = fernand;
            var f = fernand.nom;
            var g = fernand.nom[0];
            var h = fernand.nom.Length;

            var i = fernand.cours;
            var j = fernand.cours.Length;
            var k = fernand.cours[0];
            var l = fernand.cours[0].Length;
            var m = fernand.cours[0][3];

            var n = fernand.cours.Length * score[0];
            var o = fernand.nom == "Fernand";
            var p = fernand.nom.ToUpper();
            var q = fernand.nom.ToUpper().Contains("M");

            var r = score[0] / 100;
            var s = score[0] / 100.0;
            var t =
                (fernand.adresse.ville == "Jonquière"
                || fernand.adresse.ville == "Chicoutimi")
                && fernand.prenom == "Québec";

            var u = DecrireAdresse(fernand.adresse);
            var v = UnixTimeStamp(naissance);

            var w =
                UnixTimeStamp(fernand.dateInscription)
                - UnixTimeStamp(fernand.dateNaissance);

            var x =
                UnixTimeStamp(fernand.dateInscription)
                - UnixTimeStamp(fernand.dateNaissance)
                > 100000;

            // FIN
            ImprimerType(nameof(a), a);
            ImprimerType(nameof(b), b);
            ImprimerType(nameof(c), c);
            ImprimerType(nameof(d), d);
            ImprimerType(nameof(e), e);
            ImprimerType(nameof(f), f);
            ImprimerType(nameof(g), g);
            ImprimerType(nameof(h), h);
            ImprimerType(nameof(i), i);
            ImprimerType(nameof(j), j);
            ImprimerType(nameof(k), k);
            ImprimerType(nameof(l), l);
            ImprimerType(nameof(m), m);
            ImprimerType(nameof(n), n);
            ImprimerType(nameof(o), o);
            ImprimerType(nameof(p), p);
            ImprimerType(nameof(q), q);
            ImprimerType(nameof(r), r);
            ImprimerType(nameof(s), s);
            ImprimerType(nameof(t), t);
            ImprimerType(nameof(u), u);
            ImprimerType(nameof(v), v);
            ImprimerType(nameof(w), w);
            ImprimerType(nameof(x), x);
        }

        static void ImprimerType(string nom, object valeur)
        {   // Pas besoin de comprendre le code.
            Console.Write($"{nom} = ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(valeur);
            Console.ResetColor();
            Console.Write(" est de type ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(valeur.GetType());
            Console.ResetColor();
            Console.WriteLine(".");
        }
    }
}
