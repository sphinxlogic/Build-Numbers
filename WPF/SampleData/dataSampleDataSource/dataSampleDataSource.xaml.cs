﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.dataSampleDataSource
{
    using System; 
    using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
    internal class root { }
#else

    public class root : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public root()
        {
            try
            {
                Uri resourceUri = new Uri("ms-appx:/SampleData/dataSampleDataSource/dataSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
                System.Windows.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private buildversionCollection _buildversionCollection = new buildversionCollection();

        public buildversionCollection buildversionCollection
        {
            get
            {
                return this._buildversionCollection;
            }
        }
    }

    public class buildversion : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _name = string.Empty;

        public string name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (this._name != value)
                {
                    this._name = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        private string _version = string.Empty;

        public string version
        {
            get
            {
                return this._version;
            }

            set
            {
                if (this._version != value)
                {
                    this._version = value;
                    this.OnPropertyChanged("version");
                }
            }
        }

        private string _build = string.Empty;

        public string build
        {
            get
            {
                return this._build;
            }

            set
            {
                if (this._build != value)
                {
                    this._build = value;
                    this.OnPropertyChanged("build");
                }
            }
        }

        private string _public1 = string.Empty;

        public string public1
        {
            get
            {
                return this._public1;
            }

            set
            {
                if (this._public1 != value)
                {
                    this._public1 = value;
                    this.OnPropertyChanged("public1");
                }
            }
        }
    }

    public class buildversionCollection : System.Collections.ObjectModel.ObservableCollection<buildversion>
    { 
    }
#endif
}
