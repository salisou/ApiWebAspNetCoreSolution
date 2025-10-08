namespace CorsoLinQ1
{
    public class StudentiViewModel
    {
        List<Studente> studenti = new()
        {
            new Studente {Id = 1, Nome = "Alice", Cognome = "Rossi", Email = "alice.rossi@info.it", Eta = 22, Corso = "Infromatica"},
            new Studente {Id = 2, Nome = "Marco", Cognome = "Bianchi", Email = "marco.bianchi@info.it", Eta = 28, Corso = "Infromatica" },
            new Studente {Id = 3, Nome = "Laura", Cognome = "Verdi", Email = "laura.verdi@info.it", Eta = 19 , Corso = "Infromatica"},
            new Studente {Id = 4, Nome = "Giuseppe", Cognome = "Neri", Email = "giuseppe.neri@info.it", Eta = 35, Corso = "Infromatica"},
            new Studente {Id = 5, Nome = "Sofia", Cognome = "Gialli", Email = "sofia.gialli@info.it", Eta = 24 , Corso = "Infromatica"},
            new Studente {Id = 6, Nome = "Luca", Cognome = "Ferrari", Email = "luca.ferrari@info.it", Eta = 31 , Corso = "Infromatica"},
            new Studente {Id = 7, Nome = "Giulia", Cognome = "Romano", Email = "giulia.romano@info.it", Eta = 21 , Corso = "Infromatica"},
            new Studente {Id = 8, Nome = "Andrea", Cognome = "Colombo", Email = "andrea.colombo@info.it", Eta = 27 , Corso = "Infromatica"},
            new Studente {Id = 9, Nome = "Martina", Cognome = "Ricci", Email = "martina.ricci@info.it", Eta = 23, Corso = "Infromatica" },
            new Studente {Id = 10, Nome = "Francesco", Cognome = "Marino", Email = "francesco.marino@info.it", Eta = 29, Corso = "Infromatica" },
            new Studente {Id = 11, Nome = "Chiara", Cognome = "Greco", Email = "chiara.greco@info.it", Eta = 20 , Corso = "Infromatica"},
            new Studente {Id = 12, Nome = "Davide", Cognome = "Bruno", Email = "davide.bruno@info.it", Eta = 33 , Corso = "Project Managment"},
            new Studente {Id = 13, Nome = "Elena", Cognome = "Gallo", Email = "elena.gallo@info.it", Eta = 26, Corso = "Project Managment" },
            new Studente {Id = 14, Nome = "Simone", Cognome = "Costa", Email = "simone.costa@info.it", Eta = 30, Corso = "Project Managment" },
            new Studente {Id = 15, Nome = "Federica", Cognome = "Fontana", Email = "federica.fontana@info.it", Eta = 25, Corso = "Project Managment" }
        };



        public void Risultato()
        {
            // Metodo tradizionale con ciclo foreach
            List<Studente> informaticiForeach = new();

            foreach (var s in studenti)
            {
                if (s.Corso == "Infromatica")
                {
                    informaticiForeach.Add(s);
                }
                Console.WriteLine(s.Cognome);
            }

            // Stampa a video
            Console.WriteLine("Studenti del corso di Informatica:\n");
            List<Studente> informaticiLinq = studenti.Where(s => s.Corso == "Infromatica").ToList();

            foreach (var s in informaticiLinq)
            {
                Console.WriteLine(s.Nome);
            }
        }
    }
}