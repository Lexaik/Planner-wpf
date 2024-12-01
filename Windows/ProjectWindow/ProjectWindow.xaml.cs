using System.Windows;

namespace TOP_Planner.Windows.ProjectWindow;

public partial class ProjectWindow : Window
{
    public ProjectWindow()
    {
        InitializeComponent();
        Today.Content = DateTime.Now.ToString("dd");
    }
}