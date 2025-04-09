using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly BloggingContext _context;
        public Form1()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppEjemplo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new BloggingContext(optionsBuilder.Options);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var blogs = _context.Blogs.ToList();
        }
    }
}
