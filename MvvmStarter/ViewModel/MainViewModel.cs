using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmStarter.Models;

namespace MvvmStarter.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged();
            }
        }


        public Student Student
        {
            get { return _student; }
            set
            {
                _student = value;
                RaisePropertyChanged();
            }
        }

        private string _studentsName;
        private Student _student;
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public string StudentsName
        {
            get { return _studentsName; }
            set
            {
                _studentsName = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand ChangeText => new RelayCommand(CreateStudent);

        public RelayCommand<Student> DisplayPopup => new RelayCommand<Student>(Display);

        private void Display(Student student)
        {
            
        }

        private void CreateStudent()
        {
            Students.Add(new Student {Indeks = 123456, Name = StudentsName});
        }

        public void NavigatedTo()
        {
            
        }
    }
}
