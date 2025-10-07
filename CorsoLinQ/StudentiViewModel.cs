namespace CorsoLinQ
{
    public class StudentiViewModel
    {
        #region Popolamento
        List<Studenti> studente = new()
        {
            new Studenti {Id = 1, Nome = "Alice", Cognome = "Rossi", Email = "alice.rossi@info.it", Eta = 22, Corso = "Infromatica"},
            new Studenti {Id = 2, Nome = "Marco", Cognome = "Bianchi", Email = "marco.bianchi@info.it", Eta = 28, Corso = "Infromatica" },
            new Studenti {Id = 3, Nome = "Laura", Cognome = "Verdi", Email = "laura.verdi@info.it", Eta = 19 , Corso = "Infromatica"},
            new Studenti {Id = 4, Nome = "Giuseppe", Cognome = "Neri", Email = "giuseppe.neri@info.it", Eta = 35, Corso = "Infromatica"},
            new Studenti {Id = 5, Nome = "Sofia", Cognome = "Gialli", Email = "sofia.gialli@info.it", Eta = 24 , Corso = "Infromatica"},
            new Studenti {Id = 6, Nome = "Luca", Cognome = "Ferrari", Email = "luca.ferrari@info.it", Eta = 31 , Corso = "Infromatica"},
            new Studenti {Id = 7, Nome = "Giulia", Cognome = "Romano", Email = "giulia.romano@info.it", Eta = 21 , Corso = "Infromatica"},
            new Studenti {Id = 8, Nome = "Andrea", Cognome = "Colombo", Email = "andrea.colombo@info.it", Eta = 27 , Corso = "Infromatica"},
            new Studenti {Id = 9, Nome = "Martina", Cognome = "Ricci", Email = "martina.ricci@info.it", Eta = 23, Corso = "Infromatica" },
            new Studenti {Id = 10, Nome = "Francesco", Cognome = "Marino", Email = "francesco.marino@info.it", Eta = 29, Corso = "Infromatica" },
            new Studenti {Id = 11, Nome = "Chiara", Cognome = "Greco", Email = "chiara.greco@info.it", Eta = 20 , Corso = "Infromatica"},
            new Studenti {Id = 12, Nome = "Davide", Cognome = "Bruno", Email = "davide.bruno@info.it", Eta = 33 , Corso = "Project Managment"},
            new Studenti {Id = 13, Nome = "Elena", Cognome = "Gallo", Email = "elena.gallo@info.it", Eta = 26, Corso = "Project Managment" },
            new Studenti {Id = 14, Nome = "Simone", Cognome = "Costa", Email = "simone.costa@info.it", Eta = 30, Corso = "Project Managment" },
            new Studenti {Id = 15, Nome = "Federica", Cognome = "Fontana", Email = "federica.fontana@info.it", Eta = 25, Corso = "Project Managment" }
        };
        #endregion
        public void Risultato()
        {
            List<Studenti> informaticiForeach = new();
            foreach (var s in studente)
            {
                if (s.Corso == "Infromatica")
                {
                    informaticiForeach.Add(s);
                }
            }

            var informaticiLiq = studente
                .Where(s => s.Corso == "Infromatica")
                .ToList();


        }


    }
}
