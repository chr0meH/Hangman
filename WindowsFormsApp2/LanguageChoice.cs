using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LanguageChoice : Form
    {
        public static string lang;
        public LanguageChoice()
        {
            InitializeComponent();
        }

        private void UkrBtn_Click(object sender, EventArgs e)
        {
            lang = "Українська";
            Form1.words = new string[]
{
    "машина", "сонце", "річка", "пташка", "дружба", "земля", "квітка", "навчання", "робота", "молоко",
    "яблуко", "банан", "огірок", "помідор", "тарілка", "пляшка", "квартира", "вулиця", "лікарня", "аптека",
    "автобус", "корабель", "велосипед", "машиніст", "літак", "школяр", "студент", "учениця", "письменник", "музикант",
    "спортсмен", "тренер", "програміст", "директор", "менеджер", "продавець", "інженер", "рибалка", "мисливець", "батько",
    "матуся", "татусь", "дідусь", "бабуся", "подруга", "знайомий", "папуга", "хом’як", "комп’ютер", "телефон",
    "планшет", "інтернет", "малюнок", "картина", "фотограф", "відеозапис", "мікрофон", "принтер", "сканер", "зарядка",
    "батарея", "лампочка", "водоспад", "грибочок", "смородина", "полуниця", "чорниця", "груша", "кавун", "персик",
    "картопля", "морквина", "буряк", "часник", "перець", "горох", "квасоля", "пшениця", "трактор", "молоток",
    "викрутка", "замочок", "дверцята", "стеля", "дзеркало", "шторина", "крісло", "диванчик", "ліжечко", "тумбочка",
    "поличка", "вішалка", "будильник", "телевізор", "подушка", "ковдра", "матрац", "сорочка", "футболка", "курточка",
    "пальтечко", "рукавички", "черевики", "тапочки", "спідниця", "гаманець", "банкомат", "платіжка", "покупка", "товариство",
    "цінність", "магазин", "покупець", "офіціант", "ресторація", "кав’ярня", "страви", "напій", "лимонад", "коктейль",
    "замовлення", "серветка", "оплата", "відгук", "оцінка", "свято", "тиждень", "година", "хвилина", "секунда",
    "вечірка", "пригода", "пам’ятник", "запрошення", "листівка", "подарунок", "картинка", "усмішка", "доброта", "гармонія",
    "родина", "єдність", "злагода", "перемога", "надія", "мужність", "воля", "свобода", "захисник", "героїня",
    "історія", "культура", "традиція", "освіта", "наука", "майбутнє", "мрія", "повага", "чесність", "відповідальність",
    "любов", "турбота", "настрій", "щастя", "радість", "натхнення", "досвід", "емоція", "дружність", "щирість",
    "природа", "пісочок", "скарб", "тварина", "пташина", "господар", "будівля", "письменник", "прохання", "службовець",
    "працівник", "лісовик", "риболов", "мисливство", "пекарня", "їдальня", "бібліотека", "читалка", "новинка",
    "переможець", "учасник", "експонат", "виставка", "аудиторія", "сцена", "гуртожиток", "екран", "діалог", "сценарій",
    "акторка", "режисер", "кінотеатр", "виступ", "аплодисменти", "глядач", "пісня", "балет", "оркестр", "диригент",
    "піаніст", "скрипаль", "музика", "мелодія", "композитор", "поетеса", "роман", "новела", "повість", "казкар",
    "словар", "енциклопедія", "словосполучення", "термін", "переклад", "дієслово", "іменник", "прикметник", "числівник", "займенник",
    "речення", "абзац", "тема", "ідея", "думка", "аргумент", "приклад", "висновок", "почуття", "думання",
    "уважність", "концентрація", "логіка", "кмітливість", "сила", "воля", "наполегливість", "характер", "риси", "рівень",
    "успіх", "оцінювання", "результат", "аналіз", "підготовка", "відповідь", "питання", "запит", "дані", "таблиця",
    "графік", "модель", "система", "технологія", "розвиток", "досягнення", "відкриття", "експеримент", "науковець", "дослідник"
};        
            this.Close();
        }

        private void EngBtn_Click(object sender, EventArgs e)
        {
            lang = "English";        
            Form1.words = new string[] {"apple", "river", "mountain", "computer", "bottle", "table", "chair", "window", "school", "teacher",
    "student", "notebook", "pencil", "camera", "garden", "kitchen", "bedroom", "bathroom", "mirror", "guitar",
    "pillow", "blanket", "keyboard", "monitor", "printer", "wallet", "jacket", "market", "library", "bookstore",
    "airport", "airplane", "bicycle", "bus", "engine", "farmer", "doctor", "nurse", "lawyer", "driver",
    "writer", "artist", "painter", "actor", "dancer", "singer", "musician", "carpet", "ceiling", "floor",
    "roof", "wall", "door", "fence", "garage", "garden", "forest", "desert", "island", "ocean",
    "beach", "lake", "stream", "valley", "field", "village", "city", "country", "nation", "continent",
    "planet", "galaxy", "star", "moon", "sun", "weather", "season", "summer", "winter", "autumn",
    "spring", "storm", "rain", "snow", "cloud", "wind", "fog", "lightning", "thunder", "fire",
    "ice", "rock", "stone", "sand", "cliff", "hill", "path", "trail", "bridge", "tower",
    "castle", "temple", "church", "mosque", "school", "college", "university", "academy", "dormitory", "stadium",
    "court", "team", "match", "tournament", "player", "coach", "referee", "goal", "ball", "bat",
    "helmet", "uniform", "score", "record", "victory", "defeat", "fight", "battle", "army", "soldier",
    "weapon", "gun", "sword", "shield", "armor", "tank", "plane", "submarine", "ship", "boat",
    "harbor", "port", "cargo", "truck", "train", "railway", "station", "ticket", "passenger", "driver",
    "road", "highway", "street", "avenue", "crosswalk", "signal", "light", "sign", "map", "route",
    "journey", "trip", "vacation", "holiday", "hotel", "motel", "inn", "hostel", "resort", "cabin",
    "tent", "camp", "forest", "mountain", "lake", "river", "desert", "island", "adventure", "expedition",
    "explorer", "guide", "compass", "backpack", "suitcase", "luggage", "passport", "visa", "document", "form",
    "report", "file", "folder", "envelope", "letter", "email", "message", "call", "phone", "number",
    "network", "website", "page", "browser", "link", "image", "photo", "video", "channel", "account",
    "profile", "password", "username", "login", "logout", "access", "admin", "user", "guest", "member",
    "forum", "chat", "thread", "post", "comment", "reaction", "like", "dislike", "share", "notification",
    "alert", "warning", "error", "bug", "issue", "update", "version", "release", "patch", "download",
    "upload", "file", "document", "text", "editor", "code", "script", "program", "app", "software",
    "hardware", "device", "machine", "robot", "sensor", "camera", "microphone", "speaker", "screen", "display",
    "battery", "charger", "cable", "adapter", "plug", "socket", "switch", "button", "panel", "keyboard",
    "mouse", "touchpad", "monitor", "projector", "server", "network", "router", "modem", "signal", "bandwidth",
    "cloud", "storage", "database", "table", "record", "entry", "field", "form", "query", "result",
    "index", "key", "value", "type", "format", "option", "setting", "tool", "menu", "bar",
    "icon", "shortcut", "folder", "directory", "path", "location", "address", "domain", "host", "port",
    "protocol", "connection", "session", "token", "cache", "cookie", "data", "content", "media", "stream",
    "player", "controller", "console", "game", "level", "score", "ranking", "achievement", "quest", "mission",
    "enemy", "friend", "team", "guild", "leader", "member", "character", "avatar", "skin", "item" };
            
            this.Close();
        }
    }
}
