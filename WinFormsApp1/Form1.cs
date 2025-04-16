using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly BloggingContext _context;
        public Form1()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _context = new BloggingContext(optionsBuilder.Options);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var blogs = _context.Blogs.ToList();
            cmbBlog.DataSource = blogs;
            cmbBlog.DisplayMember = "Name";
            cmbBlog.ValueMember = "BlogId";

            //var blog = _context.Blogs
            //    .Include(p=> p.Posts)
            //    .Where(b=> b.BlogId==1)
            //    .FirstOrDefault();
            //foreach (var post in blog.Posts)
            //{
            //        Console.WriteLine(post.Title);
            //}
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var newPost = new Post()
            {
                Title = txtTitulo.Text,
                Content = txtCuerpo.Text,
                BlogId = Convert.ToInt32(cmbBlog.SelectedValue)
            };
            _context.Posts.Add(newPost);
            _context.SaveChanges();
        }
    }
}
