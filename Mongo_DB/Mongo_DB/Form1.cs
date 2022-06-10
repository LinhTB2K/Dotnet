using MongoDB.Driver;

namespace Mongo_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("db_login");
            IMongoCollection<MyTestObject> myTestObjectCollection = database.GetCollection<MyTestObject>("myTestObjectCollection");
            var db = client.GetDatabase("db_login");
            var dbCollection = db.GetCollection<Game>("login");
        }
    }
}