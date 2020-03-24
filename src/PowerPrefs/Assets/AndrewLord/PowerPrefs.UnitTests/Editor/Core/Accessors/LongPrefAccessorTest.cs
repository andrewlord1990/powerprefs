//
// PowerPrefs
// Copyright (C) 2016 Andrew Lord
// Apache License, Version 2.0, see LICENSE file for details
//
namespace AndrewLord.UnityPowerPrefs.Accessors.UnitTests
{
    using UnityEngine;
    using NUnit.Framework;

    public class LongPrefAccessorTest
    {
        private static readonly string TestKey = "someTestKey";

        private LongPrefAccessor accessor;

        [SetUp]
        public void SetUp()
        {
            accessor = new LongPrefAccessor();
        }

        [TearDown]
        public void TearDown()
        {
            PlayerPrefs.DeleteAll();
        }

        [Test]
        public void GivenValueStored_WhenGet_ThenValue()
        {
            var expected = 21;
            PlayerPrefs.SetString(TestKey, expected.ToString());

            var actual = accessor.Get(TestKey, -1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GivenKeyMissing_WhenGet_ThenDefault()
        {
            var expected = 31;

            var actual = accessor.Get(TestKey, expected);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GivenNoDefaultProvidedAndKeyMissing_WhenGet_ThenCharTypeDefault()
        {
            var actual = accessor.Get(TestKey);

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void WhenSet_ThenValueStored()
        {
            var expected = 12;

            accessor.Set(TestKey, expected);

            var actual = long.Parse(PlayerPrefs.GetString(TestKey, "-1"));
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GivenValueAlreadyStored_WhenSet_ThenValueOverwritten()
        {
            var expected = 23;
            PlayerPrefs.SetString(TestKey, "121");

            accessor.Set(TestKey, expected);

            var actual = long.Parse(PlayerPrefs.GetString(TestKey, "-1"));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
