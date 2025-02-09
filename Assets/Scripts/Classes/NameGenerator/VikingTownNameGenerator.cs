namespace Classes.NameGenerator
{
    public class VikingTownNameGenerator : BaseNameGenerator
    {

	    public VikingTownNameGenerator() : base("viking")
	    {
	    }
	    /// <summary>
	    /// Author: https://www.fantasynamegenerators.com/scripts/underwaterTowns.js
	    /// </summary>
	    /// <param name="include"></param>
	    /// <returns></returns>
        public override string Gen(string include = null)
        {
            string[] nm1 = { "Aoalvik", "Afvaldsnes", "Agoanes", "Agoir", "Akrafjall", "Akranes", "Akrar", "Alfgeirsvellir", "Alfsnes", "Alfsoss", "Almannafljot",
				"Almannagja", "Almdalir", "Almenningar", "Alpta", "Alptafjror", "Alptanes", "Alptaver", "Alviora", "Alost", "Ambattara", "Anabrekka",
				"Andakilsa", "Andarkelda", "Ar", "Arastaoir", "Arnallsstaoir", "Arnarboeli", "Arnarfell", "Arnarfjoror", "Arnarholt", "Arnarhvall", "Arnarnes",
				"Arnarthufa", "Arnbjargarloekr", "Arneioarstaoir", "Arnlaugsfjoror", "Asar", "Asbjarnarnes", "Asbjarnarstaoir", "Asbjarnarvik", "Asgautsstaoir",
				"Asgeirsa", "Ashildarmyrr", "Askelshofoi", "Asmundarleioi", "Asolfsleioi", "Asolfsskali", "Atlahaugr", "Atley", "Auoartoptir", "Auobrekka",
				"Auokulustaoir", "Auonar", "Auoolfsstaoir", "Auosstaoir", "Auounarstaoir", "Augastaoir", "Aurrioaa", "Aurrioaaross", "Austfiroingafjoroungr",
				"Austfiroir", "Austrvegr", "Axlarhagi", "Bakkarholt", "Balkastaoir", "Ballara", "Baro", "Baroardalr", "Baroargata", "Baroastrond", "Barosnes",
				"Barosvik", "Baugsstaoir", "Beigaoarhvall", "Beigaldi", "Bekansstaoir", "Belgsdalr", "Belgsstaoir", "Berg", "Berghlioir", "Berghylr",
				"Bergthorshvall", "Berjadalsa", "Bersastaoir", "Berserkseyrr", "Boroeyrr", "Berufell", "Berufjoror", "Beruvik", "Beruvikrhraun", "Bildsa",
				"Bildsfell", "Biskupstunga", "Bitra", "Bitrufjoror", "Bjallabrekka", "Bjargaoss", "Bragaoss", "Bjarkey", "Bjarmaland", "Bjarnardalr",
				"Bjarnarfjoror", "Bjarnarhofn", "Bjarnarnes", "Bjarnastaoir", "Bjarneyjafloi", "Bjorgyn", "Blanda", "Blonduoss", "Blaserkr", "Blaskeggsa",
				"Blaskogsa", "Blaskogar", "Blesastaoir", "Blundsvatn", "Blondudalr", "Blonduhlio", "Blondukvislir", "Bolstaoara", "Bolstaor", "Bolungavik",
				"Boroeyrr", "Borg", "Borgardalr", "Borgarfjoror", "Borgarholt", "Borgarhraun", "Borgarhofn", "Borgarloekr", "Borgarsandr", "Borgund",
				"Botarskaro", "Botarskal", "Botn", "Botnsa", "Bragaoss", "Bramsloekr", "Brattahlio", "Brattsholt", "Brautarholt", "Bravollr", "Breioa",
				"Breioabolstaor", "Breioafjoror", "Breioamyrr", "Breioarsandr", "Breioavao", "Breioavik", "Breiodalr", "Brekka", "Fagrabrekka", "Brekkur",
				"Sumarlioaboer", "Brenna", "Brenningr", "Brimilsvellir", "Brimnesskogar", "Brjansloekr", "Bramsloekr", "Brokey", "Brunahaugr", "Brunastaoir",
				"Brynjudalr", "Brynjudalsa", "Buoardalr", "Buoardalsa", "Buland", "Bulandshofoi", "Bulandsnes", "Burfell", "Byrgisvik", "Baegisa", "Boejarsker",
				"Boer", "Boomooshorn", "Boomooshraun", "Boomoostunga", "Booolfs skytja", "Boovarsdalr", "Boovarsholar", "Boovarsholt", "Boovarstoptir",
				"Dalalond", "Dalir", "Dalsfjoror", "Dalsmynni", "Deildara ", "Deildarey", "Deildargil", "Deildarhjalli", "Digranes", "Dimunarvagr", "Djupa",
				"Djupadalr", "Djupadalslond", "Djupafjoror", "Dofrar", "Drangaland", "Drangar", "Drangavik", "Drapuhlio", "Drifandi", "Dritsker",
				"Drumboddsstaoir", "Dufansdalr", "Dufunefsskeio", "Dufthaksholt", "Dufthaksskor", "Dumbshaf", "Dyflinn", "Dyflinnarskiri", "Dynskogar",
				"Dyrafjoror", "Doguroara", "Doguroarnes", "Egilsstaoir", "Eio", "Eilifsdalsa", "Einarsfjoror", "Einarshofn", "Einarssker", "Einarsstaoir",
				"Einhyrningsmork", "Eiriksey", "Eiriksfjoror", "Eiriksholmar", "Eiriksstaoir", "Eiriksvagr", "Eldgrimsstaoir", "Eldueio", "Ellioaaross",
				"Ellioaey", "Enga", "Engihlio", "Enni", "Esjuberg", "Eskifjoror", "Eskiholt", "Espiholl inn syori", "Eyjafjaroara",
				"Eyjafjaroarstrond in eystri", "Eyjafjoll", "Eyjafjoror", "Eyjara", "Eyjardalsa", "Eyjasandr", "Eyjasund", "Eyjasveit", "Landeyjar", "Eyrar",
				"Eyrarbakki", "Eyrarfell", "Eyrarland", "Eyrr", "Hrafnseyri", "Flateyri", "Narfeyri", "Ondveroareyri", "Eystribyggo", "Eystridalr", "Eyvindara",
				"Eyvindardalr", "Eyvindarfjoror", "Eyvindarholar", "Eyvindarmuli", "Fabeinsa", "Fagrabrekka", "Fagradalr", "Fagradalsa", "Fagradalsaross",
				"Fagraskogr", "Fagravik", "Faskruosfjoror", "Faxaoss", "Feldarholmr", "Fellshverfi", "Fellsmuli", "Fellsskogar", "Ferstikla", "Fiflavellir",
				"Finnafjoror", "Finnmork", "Firoafylki", "Firoir", "Fiska", "Fiskiloekr", "Fitjar", "Fjalafylki", "Fjalir", "Fjall", "Alpafjoll", "Fjaroara",
				"Fjaora", "Fjarora", "Fjaroarhorn", "Fjoll", "Eyjafjoll", "Flangastaoir", "Fjoll", "Eyjafjoll", "Flangastaoir", "Flatatunga", "Flateyjardalr",
				"Fljot", "Markarfljot", "Skjalfandafljot", "Fljotsa", "Fljotsdalr", "Fljotshlio", "Fljotshverfi", "Floi", "Flokadalr", "Flokadalsa",
				"Flokavaroi", "Flugumyrr", "Fnjoskadalr", "Fnjoskadalsa", "Fnjoska", "Folafotr", "Forsa", "Forsfjoror", "Forsvollr", "Forsoeludalr", "Framnes",
				"Frioleifsdalr", "Frioleifsdalsa", "Friomundara", "Frooa", "Frooaross", "Fulaloekr", "Fyllarloekr", "Fura", "Faereyjar", "Galmastrond",
				"Galmansstrond", "Galmarstrond", "Gamlastrond", "Galtarhamarr", "Garoar", "Jorundarholt", "Garoarsholmr", "Garpsdalr", "Gata", "Gaular",
				"Gaulverjaboer", "Gautland", "Gautsdalr", "Geiradalr", "Geirastaoir", "Geirhildarvatn", "Geirland", "Geirlandsa", "Geirmundarstaoir",
				"Saemundarstaoir", "Geirmundarvagr", "Geirolfsgnupr", "Geirsa", "Geirshlio", "Geirsholmr", "Geirvor", "Geirthjofsfjoror", "Geitland", "Gerpir",
				"Gil", "Gila", "Gilhagi", "Gilja", "Gilsa", "Gilsbakki", "Gilsfjoror", "Gislavotn", "Gislavatn", "Glaumsteinn", "Glera nyrori", "Glera syori",
				"Gljufra", "Glooafeykisa", "Gnupa", "Gnupar", "Gnupr", "Gnupi", "Gnupudalr", "Gnupufell", "Gnupverjahreppr", "Goodalir", "Guodalir",
				"Gotaloekr", "Grenitresnes", "Grenivik", "Grenjaoarstaoir", "Grenmarr", "Grimsa", "Grimsaross", "Grimsdalr", "Grimsey", "Grimsgil", "Grimsnes",
				"Grimulfsvotn", "Grindaloekr", "Grindavik", "Grindill", "Grillir", "Grindr", "Grisartunga", "Grjota", "Grjotvallarmuli", "Grones", "Groustaoir",
				"Grund", "Grunnafjoror", "Groenavatn", "Groeningr", "Grof", "Guobrandsstaoir", "Guodalir", "Guolaugshofoi", "Gufua", "Gufa", "Gufaross",
				"Gufudalr", "Gufufjoror", "Gufunes", "Gufuskalar", "Gullberastaoir", "Gunnarsholt", "Gunnbjarnarsker ", "Gunnlaugsstaoir", "Gunnolfsa",
				"Gunnolfsfell", "Gunnolfsvik", "Gunnsteinar", "Gunnsteinsstaoir", "Gygjarsporsa", "Gyldarhagi", "Galdrahagi", "Gonguskaro", "Gonguskarosa",
				"Gonguskarosaross", "Haddingjadalr", "Hafgrimsfjoror", "Hafnarfjall", "Hafnarfjoll", "Hafnarfjoror", "Hafnarlond", "Hafnaross ", "Hafr",
				"Hafrafell", "Hafragil", "Hafranes", "Hafrsa", "Hafrsfjoror", "Hafsbotn", "Hafsloekr", "Hagagaror", "Haganes", "Hagbarosholmr", "Hagi",
				"Fornhagi", "Hakaskaro", "Hakonarhella", "Hakonarstaoir", "Hallarmuli", "Halland", "Hallbjarnarvorour", "Hallgeirsey", "Hallkelsholar",
				"Hallkelsstaoir", "Hallsteinsnes", "Halogaland", "Hals", "Halsaland", "Halsar", "Halsgrof", "Hamarr", "Hamarsa", "Hamrar", "Hamundarstaoir",
				"Hanatun", "Hareksstaoir", "Hasteinssund", "Haugar", "Haugavao", "Haugr", "Haukadalr", "Haukagil", "Hauksgrafir", "Hauksstaoir", "Havararlon",
				"Heoinshofoi", "Hefn", "Hegranes", "Heggsgeroismuli", "Heioaboer", "Heior", "Heinabergsa", "Heinabergsar", "Helgafell", "Helgafjall",
				"Helgahraun", "Helgahvall", "Helgasker", "Helgastaoir", "Helgavatn", "Helgavatni", "Hellisdalr", "Hellisfitjar", "Hellisfjoror", "Hellishraun",
				"Hengiforsa", "Herfuroa", "Hergilsey", "Herjolfsdalr", "Herjolfsfjoror", "Herjolfshofn", "Herjolfsnes", "Hernar", "Hestfjoror", "Hestr",
				"Heynes", "Hildisey", "Hisargafl", "Hita", "Hitara", "Hitardalr", "Hjallaland", "Hjallanes", "Hjalli", "Hjaltadalr", "Hjaltaeyrr",
				"Hjaltdaelalaut", "Hjaltland", "Hjaroarholt", "Hjaroarnes", "Herdisarnes", "Hjaroarvatn", "Hjorleifshofoi", "Hlaohamarr", "Hleiorargaror",
				"Hlio", "Jokulsarhlio", "Hlioir", "Hlioum", "Hlioarendi", "Hlioarenda", "Hlioarlond", "Hlymrek", "Hloouvik", "Hnjoska", "Hnjoskadalsa",
				"Hnjoskadalr", "Hofgaroar", "Hofsa", "Hofsfell", "Hofsland", "Hofslond", "Hofstaoir", "Hofsteigr", "Hofsvagr", "Holar", "Hreppholar",
				"Klaustrholar", "Vestrhopsholar", "Krumsholar", "Holl", "Holmgaror", "Holmkelsa", "Holmr", "Holmsa", "Holmslatr", "Holm", "Holmslond",
				"Holmlond", "Holt", "Eyjafjollum", "Holtastaoir", "Horn it eystra", "Horn it vestra", "Hornafjaroarstrond", "Hornafjoror", "Hornstrandir",
				"Hrafnagil", "Hrafnagja", "Hrafnista", "Hrafnkelsdalr", "Hrafnsfjoror", "Hrafnstoptir", "Hranafall", "Hranastaoir", "Hraun", "Berserkjahraun",
				"Hraunaheior", "Hraunadalr", "Hraungeroi", "Hraungeroingahreppr", "Hraunhafnara", "Hraunhofn", "Hraunsass", "Hraunsfjoror", "Hraunsholtsloekr",
				"Hraunsloekr", "Hreouvatn", "Hreggsgeroismuli", "Heggsgeroismuli", "Hreioarsgeroi", "Hringariki", "Hringdalir", "Hringsstaoir", "Hrip",
				"Hrisar", "Hrisateigr", "Hrisey", "Hroarsholt", "Hroarsloekr", "Hroarsholtsloekr", "Hrokkelsstaoir", "Hroksholt", "Hrolleifsdalr",
				"Hrolleifsdalsa", "Hrunamannahreppr", "Hrutafjaroardalr", "Hrutafjaroarstrond in eystri", "Hrutafjoror", "Hrutsstaoir", "Hraereksgil",
				"Hunavatn", "Hunavatnsthing", "Hundadalr", "Hundsnes", "Husagaror", "Husavik", "Husnar", "Hvaleyrr", "Hvalfjaroarstrond", "Hvalfjoror", "Hvall",
				"Storolfshvall", "Hvallatr", "Hvalsey", "Hvalseyjar", "Hvalsnesskriour", "Hvalvatnsfjoror", "Hvammr", "Hvanna", "Hvanndalir", "Hvanneyrr",
				"Hvarf", "Hvarfsgnipa", "Hvassahraun", "Hvatastaoir", "Hvinir", "Hvinisfjoror", "Hvinverjadalr", "Hvita", "Hvitarsioa", "Hvitbjorg",
				"Hvitramannaland", "Haell", "Hofoabrekka", "Hofoalond", "Hofoarsandr", "Hofoastrond", "Hofoi", "Hjorleifshofoi", "Bulandshofoi", "Hofn",
				"Hognastaoir", "Hokustaoir", "Horoadalr", "Horoadalsa", "Horoaholar", "Horoaland", "Horga", "Horgardalr", "Horgardalsa", "Horgsholt",
				"Hoskuldsar", "Hoskuldsloekr", "Hoskuldsstaoir", "Hoskuldsvatn", "Iafjoror", "Ingimundarholt", "Ingjaldsgnupr", "Ingjaldshvall",
				"Ingjaldssandr", "Ingolfsfell", "Ingolfsfjoror", "Ingolfshofoahverfi", "Ingolfshofoi", "Ira", "Iara", "Isafjaroardjup", "Isafjoror",
				"Islandshaf", "Isleifsstaoir", "Isrooarstaoir", "Jaoarr", "Jafnaskaro", "Jannaskaro", "Jamtaland", "Jarofallsgil", "Jarolangsstaoir",
				"Jolgeirsstaoir", "Jorunnarstaoir", "Jokulsa", "Breioamerkursandi", "Solheimasandi", "Fjollum", "Jokulsdalr", "Jokulsfell", "Jokulsfiroir",
				"Jokulvikra", "Jokulsvikra", "Solheimasandi", "Jokulsa", "Jolduhlaup", "Joldusteinn", "Jorundarfell", "Jorundarholt", "Josureio", "Kalda",
				"Kaldaross", "Kaldakinn", "Kaldaklofsa", "Kaldakvisl", "Tungufljot", "Kaldbakr", "Kaldbaksvik", "Kalfa", "Kalfagrafir", "Kalfborgara",
				"Kolborgara", "Kalfskinn", "Kallnesingahreppr", "Kalmansa", "Kalmarsa", "Kalmanstunga", "Kambakista", "Kambr", "Kambsdalr", "Kambsnes",
				"Kampaholt", "Karlafjoror", "Karlastaoir", "Karlsa", "Karlsbrekka", "Hromundarstaoir", "Karlsdalr", "Karlsfell", "Karnsa", "Karnsarland",
				"Karsstaoir", "Katanes", "Keflavik", "Keldudalr", "Keldugnupr", "Kelduhverfi", "Keldunes", "Kerlingara", "Kerlingarfjoror", "Kerseyrr",
				"Kjorseyrr", "Ketilseyrr", "Ketilsfjoror", "Ketilsstaoir", "Kiojaberg", "Kiojafell", "Kiojaklettr", "Kiojaleit", "Kirkjubolstaor", "Kirkjuboer",
				"Kirkjufell", "Kirkjufjoror", "Kirkjusandr", "Kjalarnes", "Kjalkafjoror", "Kjallaksholl", "Kjallaksstaoir", "Kjaransvik", "Kjarra",
				"Kjarradalr", "Kjos", "Kjolr", "Kjolvararstaoir", "Kleifar", "Kleifarlond", "Klofasteinar", "Klofningar", "Knafaholar", "Knappadalr",
				"Knappsstaoir", "Knarrarnes", "Knefilsdalsa", "Kolbeinsaross", "Kolbeinsdalr", "Kolbeinsey", "Kolbeinsstaoir", "Kolbeinsvik", "Kolgrafafjoror",
				"Kolgrafir", "Kolkumyrar", "Kollafjaroarheior", "Kollafjoror", "Kollavik", "Kollshamarr", "Kollshamrar", "Kollsloekr", "Kollsveinsstaoir",
				"Kollsvik", "Kolssonafell", "Kopanes", "Koranes", "Kraunaheior", "Krokr", "Kroksdalr", "Kroksfjaroarmuli", "Kroksfjaroarnes", "Kroksfjoror",
				"Kroppr", "Krossa", "Krossass", "Krossavik", "Krossholar", "Krysuvik", "Krisuvik", "Kraeklingahlio", "Krofluhellir", "Kuoafljot",
				"Kvernvagastrond", "Kvia", "Kviabekkr", "Kvigandafjoror", "Kvigandisfjoror", "Kvigandanes", "Kviguvagabjorg", "Kylansholar", "Kylansholmar",
				"Lagarfljot", "Lagarfljotsstrandir", "Lagey", "Lambafellsa", "Lambastaoir", "Landamot", "Landbrot", "Langa", "Langadalr", "Langadalsa",
				"Langaholt", "Langanes", "Langavatnsdalr", "Laugar", "Laugarbrekka", "Laugardalr", "Laxa", "Laxardalr", "Leioolfsfell", "Leioolfsstaoir",
				"Leikskalar", "Leira", "Leirhofn", "Leiruloekr", "Leiruvagr", "Lioandisnes", "Linakradalr", "Ljosavatn", "Ljosavatnsskaro", "Ljotarstaoir",
				"Ljotolfsstaoir", "Loomundarfjoror", "Loomundarhvammr", "Lofot", "Lomagnupslond", "Lon", "Skipalon", "Lonland", "Lonlond", "Lonsheior",
				"Lunansholt", "Lundar", "Lundarbrekka", "Lundr", "Lysa", "Loekjarbotnar", "Longuhlio", "Mana", "Manafell", "Manarfell", "Manavik", "Manathufa",
				"Mannafallsbrekka", "Mannafallsbrekkur", "Marboeli", "Hanatun", "Markarfljot", "Masstaoir", "Mavahlio", "Meoalfarssund", "Meoalfell",
				"Meoalfellsstrond", "Fellsstrond", "Meoallond", "Melahverfi", "Melar", "Melrakkadalr", "Melrakkanes", "Merkigil", "Merkrhraun", "Merrhaefi",
				"Mioengi", "Miofell", "Miofjoror", "Miohus", "Miojokull", "Mioskali", "Migandi", "Mikilsstaoir", "Miklagaror", "Miklagil", "Minthakseyrr",
				"Mjosyndi", "Mjovadalr", "Mjovadalsa", "Mjovafjoror", "Mjola", "Mjors", "Moberg", "Mobergsbrekkur", "Mooolfsgnupr", "Moeioarhvall", "Mogilsa",
				"Mogilsloekr", "Moldatun", "Mor", "Mosfell", "Mostr", "Mulafell", "Muli", "Munaoarnes", "Mydalr", "Mydalsa", "Myrar", "Myrka", "Myrr", "Myvatn",
				"Maelifell", "Maelifellsa", "Maelifellsdalr", "Maelifellsgil", "Maerin", "Moorufell", "Mooruvellir", "Mork", "Narfasker", "Nattfaravik",
				"Naumdaelafylki", "Naumudalr", "Nautabu", "Neshraun", "Njaroey", "Njarovik", "Norofjoror", "Norolendingafjoroungr", "Noromoerr", "Norora",
				"Nororardalr", "Nororlond", "Norotunga", "Norvegr", "Nykomi", "Oddgeirsholar", "Oddi", "Oddsass", "Odeila", "Ofeigsfjoror", "Ofeigsstaoir",
				"Ofrustaoir", "Ofoera", "Olafsdalr", "Olafsfjoror", "Olafsvellir", "OlafsvikSnaef", "Oleifsborg", "Oleifsbjorg", "Orkneyjar", "Ormsa",
				"Ormarsa", "Ormsdalr", "Ormsstaoir", "Orrastaoir", "Orrostudalr", "Osar", "Unaoss", "Osfjoll", "Osomi", "Oss", "Osta", "Osvifsloekr", "Papey",
				"Papyli", "Patreksfjoror", "Pettlandsfjoror", "Ranga", "Rangaoarvaroa", "Rangaross", "Rangarvellir", "Raptaloekr", "Rauoa",
				"Rauoabjarnarstaoir", "Rauoafell it eystra", "Rauoagnupr", "Rauoaloekr", "Rauoamelr inn ytri", "Rauoamelslond", "Rauoasandr", "Rauoaskrioa",
				"Rauoaskrioulond", "Rauoaskriour", "Rauokollsstaoir", "Rauosgil", "Raufarfell it eystra", "Raufarnes", "Raumsdalr", "Raumsdaelafylki",
				"Refsstaoir", "Reistara", "Reistargnupr", "Reyoarfell", "Reyoarfjall", "Reyoarfjoror", "Reyoarmuli", "Reyoarvatn", "Reykir inir efri",
				"Kopareykir", "Reykjaa", "Reykjadalr", "Reykjadalsa", "Reykjahlio", "Reykjaholar", "Reykjaholt", "Reykjanes", "Reykjarfjoror", "Reykjarholl",
				"Reykjavellir ", "Reynir", "Reynisnes", "Reyrvollr", "Rooreksgil", "Rogaland", "Rosmhvalanes", "Rykinsvik", "Rytagnupr", "Rond", "Salteyraross",
				"Sanda", "Sandbrekka", "Sanddalr", "Sandeyrara", "Sandfell", "Sandgil", "Sandholaferja", "Sandloekr", "Sandnes", "Sandvik", "Sauoa",
				"Sauoadalr", "Sauoafellslond", "Sauoanes", "Saurbaer", "Saxahvall", "Selaeyrr", "Selalon", "Selardalr", "Selasund", "Selfors", "Seljalandsa",
				"Seljalandsmuli", "Seljasund", "Selsloekr", "Seltjarnarnes", "Selvagr", "Seyoarfjoror", "Seyoisfjoror", "Sioa", "Siglufjofor", "Siglunes",
				"Sigluvik", "Sigmundarakr", "Sigmundarnes", "Sigmundarstaoir", "Signyjarbruor", "Signyjarbuoir", "Signyjarstaoir", "Silfrastaoahlio",
				"Sireksstaoir", "Sjoland", "Sjonafjoror", "Skagafjoror", "Skagastrond", "Skagi", "Skal", "Skalabrekka", "Skalafell", "Skalaholt", "Skalamyrr",
				"Skalanes", "Skalavik", "Skaldskelmisdalr", "Skali", "Skallanes", "Skalmarkelda", "Skalmarnes", "Skaney", "Skapta", "Skaptafellsthing",
				"Skaptaholt", "Skaro", "Svignaskaro", "Skarosbrekka", "Skarfanes", "Skarfsnes", "Skeggjastaoir", "Skeio", "Skeiosbrekkur", "Skeljabrekka",
				"Skioadalr", "Skioastaoir", "Skjaldabjarnarvik", "Skjaldey", "Skjalfandafljotsoss", "Skjalfandi", "Skjalgdalsa", "Skjoldolfsnes",
				"Skjoldolfsstaoir", "Skogahverfi", "Skogar inir eystri", "Skogarstrond", "Skorradalr", "Skorraey", "Skorraholt", "Skorravik", "Skramuhlaupsa",
				"Skrattafell", "Skraumuhlaupsa", "Skrionisenni", "Skrioinsenni", "Skrioudalr", "Skruoey", "Skruor", "Skufsloekr", "Skuggabjorg", "Skulastaoir",
				"Skutilsfjoror", "Skoro", "Skotufjoror" };

			return getRndA(nm1);
        }
    }
}