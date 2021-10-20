using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace GyroScope.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAbleToAddToOrder()
        {
            Order o = new Order();
            o.AddItem(new LeoLambGyro());
            Assert.NotEmpty(o.CurrentOrder);
        }

        [Fact]
        public void ShouldBeAbleRoRemoveFromOrder()
        {
            Order o = new Order();
            LeoLambGyro llg = new LeoLambGyro();
            o.AddItem(llg);
            o.Remove(llg);
            Assert.Empty(o.CurrentOrder);
        }

        [Fact]
        public void ShouldImplimentNotifyCollectionChanged()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }

        [Fact]
        public void ShouldImplimentNotifyPropertyChanged()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        [Fact]
        public void ShouldRaiseCollectionChangedEvent()
        {
            Order o = new Order();
            LeoLambGyro llg = new LeoLambGyro();
            var wasCalled = false;
            o.AddItem(llg);
            o.CollectionChanged += (sender, e) => { wasCalled = true; };
            Assert.True(wasCalled);
            wasCalled = false;
            o.Remove(llg);
            o.CollectionChanged += (sender, e) => { wasCalled = true; };
            Assert.True(wasCalled);
        }

    }
}
