namespace Classes.NameGenerator
{
    public class OrcTownNameGenerator : BaseNameGenerator
    {

	    public OrcTownNameGenerator() : base("orc")
	    {
	    }
	    /// <summary>
	    /// Author: https://www.fantasynamegenerators.com/scripts/elfTowns.js
	    /// </summary>
	    /// <param name="include"></param>
	    /// <returns></returns>
        public override string Gen(string include = null)
        {
            string[] nm1 = { "A", "A'", "Af", "Al", "All", "Aly", "Am", "Amy", "An", "Any", "Ar", "As", "Ash", "Asy", "Ay", "Ca", "Cy", "E", "E'", "Ef", "El",
				"Ell", "Ely", "Em", "Emy", "En", "Eny", "Er", "Es", "Esh", "Esy", "Ey", "F", "Fa", "Fel", "Fil", "Fy", "Fyl", "Ga", "Gal", "Ha", "He", "Hy",
				"I", "If", "Il", "Ill", "Ily", "Im", "Imy", "In", "Iny", "Ir", "Is", "Ish", "Isy", "Iy", "Ja", "Ji", "K", "Ka", "Ke", "Ky", "L", "La", "Le",
				"Lel", "Lil", "Ly", "Lyl", "M", "Ma", "Math", "Me", "Mel", "Mil", "Mor", "My", "Myl", "Myt", "Myth", "N", "Na", "Ne", "Nel", "Nil", "Ny", "Nyl",
				"Nyt", "Nyth", "O", "O'", "Of", "Ol", "Oll", "Oly", "Om", "Omy", "On", "Ony", "Or", "Os", "Osh", "Osy", "Oy", "Ra", "Re", "Ry", "S", "Sa",
				"Sel", "Sh", "Sha", "She", "Shyl", "Sil", "Sy", "Syl", "Th", "Tha", "The", "Thel", "Thil", "Thy", "Thyl", "U", "Ul", "Ull", "Uly", "Um", "Umy",
				"Un", "Uny", "Uy", "W", "Wa", "We", "Y", "Y'", "Ya", "Ye", "Yl", "Yll" };
			string[] nm2 = { "al", "el", "en", "an", "ana", "ena", "aena", "a", "i", "ren", "ran", "eth", "ath", "a", "e", "o", "h", "ha", "he", "ho", "f", "fa",
				"fe", "l", "le", "la", "m", "me", "ma", "ne", "na", "n", "s", "sa", "se", "ve", "va" };
			string[] nm3 = { " Aethel", " Aiqua", " Alari", " Alora", " Ancalen", " Anore", " Asari", " Dorei", " Dorthore", " Edhil", " Esari", " Lenora",
				" Serin", " Serine", " Shaeras", " Taesi", " Thalas", " Thalor", " Thalore", " Themar", " Tirion", " Unarith", " Belanore", " Caelora",
				" Nalore", " Entheas", " Ennore", " Elunore", " Allanar", " Ortheiad", "bel", "belle", "dell", "dorei", "groth", "hil", "hona", "hone", "kadi",
				"lean", "lenor", "lenora", "lian", "lin", "lion", "lon", "lona", "lond", "lone", "luma", "lume", "luna", "lune", "mel", "melle", "naes", "nas",
				"neas", "nor", "nora", "nore", "noris", "qua", "rion", "rius", "sari", "sera", "serin", "serine", "shara", "shys", "taesi", "talos", "thaes",
				"thalas", "thas", "theas", "themar", "thyr" };

			return getRndA(nm1) + getRndA(nm2) + getRndA(nm3);
        }
    }
}