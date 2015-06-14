﻿/* Copyright 2015 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace MongoDB.Bson.Tests.ObjectModel
{
    [TestFixture]
    public class BsonStringTests
    {
        [Test]
        public void implicit_conversion_from_string_should_return_new_instance(
            [Values("x")]
            string value)
        {
            var result1 = (BsonString)value;
            var result2 = (BsonString)value;

            result2.Should().NotBeSameAs(result1);
        }

        [Test]
        public void implicit_conversion_from_string_should_return_precreated_instance(
            [Values("")]
            string value)
        {
            var result1 = (BsonString)value;
            var result2 = (BsonString)value;

            result2.Should().BeSameAs(result1);
        }

        [Test]
        public void precreated_instances_should_have_the_expected_value(
            [Values("")]
            string value)
        {
            var result = (BsonString)value;

            result.Value.Should().Be(value);
        }
    }
}
