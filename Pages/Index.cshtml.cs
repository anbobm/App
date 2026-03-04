using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : LÜCKE4
{
    public int AnzahlSchueler { get; set; }

    public List<Schueler> Schueler { get; set; }

    public List<Schueler> EinserSchueler { get; set; }

    public void LÜCKE5()
    {
        var db = new AppContext();

        Schueler = db.Schueler.LÜCKE6();

        EinserSchueler = db.Schueler
            .Where(schueler => schueler.LÜCKE7 == 1)
            .ToList();

        AnzahlSchueler = Schueler.Count();
    }
}