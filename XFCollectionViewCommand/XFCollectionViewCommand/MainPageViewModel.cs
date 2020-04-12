using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFCollectionViewCommand
{
    class MainPageViewModel
    {
        public List<string> People { get; set; }
        public MainPageViewModel()
        {
            People = new List<string>();
            People.AddRange(new[]
            {
                "person1",
                "person2",
                "person3",
                "person4",
            });

            TappedCommand = new Command(OnTapped);
        }

        private void OnTapped(object obj)
        {
            //タップされたときの処理
        }

        public Command TappedCommand { get; }
    }
}
