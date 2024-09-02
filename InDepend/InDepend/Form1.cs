namespace InDepend
{
    public partial class Form1 : Form
    {
        private readonly ISingletonRandomService _singletonRandomService;
        private readonly ISingletonRandomService _singletonRandomService2;
        private readonly ITransientRandomService _transientRandomService;
        private readonly ITransientRandomService _transientRandomService2;
        private readonly IScopedRandomService _scopedRandomService;
        private readonly IScopedRandomService _scopedRandomService2;

        public Form1(ISingletonRandomService singletonRandomService, ISingletonRandomService singletonRandomService2, ITransientRandomService transientRandomService, ITransientRandomService transientRandomService2, IScopedRandomService scopedRandomService, IScopedRandomService scopedRandomService2)
        {
            _singletonRandomService = singletonRandomService;
            _singletonRandomService2 = singletonRandomService2;
            _transientRandomService = transientRandomService;
            _transientRandomService2 = transientRandomService2;
            _scopedRandomService = scopedRandomService;
            _scopedRandomService2 = scopedRandomService2;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(
            $"Singleton: \n{_singletonRandomService.GetRandomNumber()}\n" +
            $"{_singletonRandomService2.GetRandomNumber()}\n" +
            $"Transient: \n{_transientRandomService.GetRandomNumber()}\n" +
            $"{_transientRandomService2.GetRandomNumber()}\n" +
            $"Scoped: \n{_scopedRandomService.GetRandomNumber()}\n" +
            $"{_scopedRandomService2.GetRandomNumber()}","AddSingelton AddTransient AddScoped");
        }
    }
}
