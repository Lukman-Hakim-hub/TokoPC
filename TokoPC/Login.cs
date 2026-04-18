
using TokoPC.Views; 

namespace TokoPC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Berhasil");
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Berhasil sebagai User");
            PublicForm publicForm = new PublicForm();
            this.Hide();
            publicForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }
    }
}
