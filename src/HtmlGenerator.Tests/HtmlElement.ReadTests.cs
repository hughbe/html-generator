using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HtmlGenerator.Tests
{
    public partial class HtmlElementTests
    {
        [Fact]
        public void Ancestors_OneLayerOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlElement child2 = new HtmlElement("child2");

            parent.Add(child1, child2);

            VerifyAncestors(child1, null, new HtmlElement[] { parent });
            VerifyAncestors(child1, "parent", new HtmlElement[] { parent });
            VerifyAncestors(child1, "PARENT", new HtmlElement[] { parent });
            VerifyAncestors(child1, "child1", new HtmlElement[0]);
            VerifyAncestors(child1, "any", new HtmlElement[0]);
        }

        [Fact]
        public void Ancestors_TwoLayersOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child");
            HtmlElement grandchild1 = new HtmlElement("child");

            HtmlElement child2 = new HtmlElement("child");

            parent.Add(child1, child2);
            child1.Add(grandchild1);

            VerifyAncestors(grandchild1, null, new HtmlElement[] { child1, parent });
            VerifyAncestors(grandchild1, "child", new HtmlElement[] { child1 });
            VerifyAncestors(grandchild1, "parent", new HtmlElement[] { parent });
            VerifyAncestors(grandchild1, "PARENT", new HtmlElement[] { parent });
            VerifyAncestors(grandchild1, "any", new HtmlElement[0]);
        }

        [Fact]
        public void Ancestors_ThreeLayersOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child");
            HtmlElement grandchild1 = new HtmlElement("child");
            HtmlElement greatGrandchild = new HtmlElement("greatgrandchild");

            HtmlElement child2 = new HtmlElement("child");
            HtmlElement grandchild2 = new HtmlElement("grandchild");

            parent.Add(child1, child2);
            child1.Add(grandchild1);
            child2.Add(grandchild2);

            grandchild1.Add(greatGrandchild);

            VerifyAncestors(greatGrandchild, null, new HtmlElement[] { grandchild1, child1, parent });
            VerifyAncestors(greatGrandchild, "child", new HtmlElement[] { grandchild1, child1 });
            VerifyAncestors(greatGrandchild, "parent", new HtmlElement[] { parent });
            VerifyAncestors(greatGrandchild, "PARENT", new HtmlElement[] { parent });
            VerifyAncestors(greatGrandchild, "greatgrandchild", new HtmlElement[0]);
            VerifyAncestors(greatGrandchild, "any", new HtmlElement[0]);
        }

        [Fact]
        public void Ancestors_NoAncestors_ReturnsEmpty()
        {
            HtmlElement parent = new HtmlElement("parent");

            VerifyAncestors(parent, null, new HtmlElement[0]);
            VerifyAncestors(parent, "parent", new HtmlElement[0]);
            VerifyAncestors(parent, "any", new HtmlElement[0]);
        }

        private static void VerifyAncestors(HtmlElement element, string tag, HtmlElement[] expected)
        {
            HtmlElement[] expectedIncludingSelf;
            if (tag == null || element.Tag == tag)
            {
                expectedIncludingSelf = new HtmlElement[expected.Length + 1];
                Array.Copy(expected, 0, expectedIncludingSelf, 1, expected.Length);
                expectedIncludingSelf[0] = element;
            }
            else
            {
                expectedIncludingSelf = expected;
            }

            if (tag == null)
            {
                Assert.Equal(expected, element.Ancestors());
                Assert.Equal(expectedIncludingSelf, element.AncestorsAndSelf());
            }
            Assert.Equal(expected, element.Ancestors(tag));
            Assert.Equal(expectedIncludingSelf, element.AncestorsAndSelf(tag));
        }

        public static IEnumerable<object[]> Attributes_TestData()
        {
            yield return new object[] { new HtmlAttribute[0] };
            yield return new object[] { new HtmlAttribute[] { new HtmlAttribute("attribute1") } };
            yield return new object[] { new HtmlAttribute[] { new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2") } };
        }

        [Theory]
        [MemberData(nameof(Attributes_TestData))]
        public void Attributes(HtmlAttribute[] attributes)
        {
            HtmlElement element = new HtmlElement("element", attributes);
            Assert.Equal(attributes, element.Attributes().ToArray());

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.Equal(attributes, element.Attributes().ToArray());

            // Ignores elements
            element.Add(new HtmlElement("element"));
            Assert.Equal(attributes, element.Attributes().ToArray());
        }

        [Fact]
        public void Descendants_OneLayerOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlElement child2 = new HtmlElement("child2");

            parent.Add(child1, child2);

            VerifyDescendants(parent, null, new HtmlElement[] { child1, child2 });
            VerifyDescendants(parent, "child1", new HtmlElement[] { child1 });
            VerifyDescendants(parent, "CHILD1", new HtmlElement[] { child1 });
            VerifyDescendants(parent, "any", new HtmlElement[0]);
        }

        [Fact]
        public void Descendants_TwoLayersOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlElement grandchild1 = new HtmlElement("grandchild1");

            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement grandchild2 = new HtmlElement("grandchild2");
            HtmlElement grandchild3 = new HtmlElement("grandchild3");
            HtmlElement grandchild4 = new HtmlElement("grandchild3");

            HtmlElement child3 = new HtmlElement("child3");
            HtmlElement child4 = new HtmlElement("child3");
            HtmlElement grandchild5 = new HtmlElement("child3");

            parent.Add(child1, child2, child3, child4);
            child1.Add(grandchild1);
            child2.Add(grandchild2, grandchild3, grandchild4);
            child4.Add(grandchild5);

            VerifyDescendants(parent, null, new HtmlElement[] { child1, grandchild1, child2, grandchild2, grandchild3, grandchild4, child3, child4, grandchild5 });
            VerifyDescendants(parent, "grandchild1", new HtmlElement[] { grandchild1 });
            VerifyDescendants(parent, "grandchild3", new HtmlElement[] { grandchild3, grandchild4 });
            VerifyDescendants(parent, "GRANDCHILD3", new HtmlElement[] { grandchild3, grandchild4 });
            VerifyDescendants(parent, "child3", new HtmlElement[] { child3, child4, grandchild5 });
            VerifyDescendants(parent, "any", new HtmlElement[0]);
        }

        [Fact]
        public void Descendants_ThreeLayersOfElements_ReturnsExpected()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            HtmlElement grandchild1 = new HtmlElement("grandchild1");
            HtmlElement greatGrandchild1 = new HtmlElement("greatgrandchild1");
            HtmlElement greatGrandchild2 = new HtmlElement("greatgrandchild2");

            HtmlElement child2 = new HtmlElement("child2");
            HtmlElement grandchild2 = new HtmlElement("Grandchild2");

            parent.Add(child1, child2);
            child1.Add(grandchild1);
            child2.Add(grandchild2);
            grandchild1.Add(greatGrandchild1);
            grandchild1.Add(greatGrandchild2);

            VerifyDescendants(parent, null, new HtmlElement[] { child1, grandchild1, greatGrandchild1, greatGrandchild2, child2, grandchild2 });
        }

        [Fact]
        public void Descendants_NoElements_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("element");
            VerifyDescendants(element, null, new HtmlElement[0]);
            VerifyDescendants(element, "any", new HtmlElement[0]);
        }

        private static void VerifyDescendants(HtmlElement element, string tag, HtmlElement[] expected)
        {
            HtmlElement[] expectedIncludingSelf;
            if (tag == null || element.Tag == tag)
            {
                expectedIncludingSelf = new HtmlElement[expected.Length + 1];
                Array.Copy(expected, 0, expectedIncludingSelf, 1, expected.Length);
                expectedIncludingSelf[0] = element;
            }
            else
            {
                expectedIncludingSelf = expected;
            }

            if (tag == null)
            {
                Assert.Equal(expected, element.Descendants());
                Assert.Equal(expectedIncludingSelf, element.DescendantsAndSelf());
            }
            Assert.Equal(expected, element.Descendants(tag));
            Assert.Equal(expectedIncludingSelf, element.DescendantsAndSelf(tag));
        }


        public static IEnumerable<object[]> Elements_Method_TestData()
        {
            HtmlElement[] count0 = new HtmlElement[0];
            HtmlElement[] count1 = new HtmlElement[] { new HtmlElement("h1") };
            HtmlElement[] count2 = new HtmlElement[] { new HtmlElement("h1"), new HtmlElement("h2") };
            HtmlElement[] count3 = new HtmlElement[] { new HtmlElement("h1"), new HtmlElement("h2"), new HtmlElement("h1") };

            // No name
            yield return new object[] { count0, null, count0 };
            yield return new object[] { count1, null, count1 };
            yield return new object[] { count2, null, count2 };

            // Element exists
            yield return new object[] { count1, "h1", new HtmlElement[] { count1[0] } };
            yield return new object[] { count1, "H1", new HtmlElement[] { count1[0] } };
            yield return new object[] { count2, "h1", new HtmlElement[] { count2[0] } };
            yield return new object[] { count2, "h2", new HtmlElement[] { count2[1] } };
            yield return new object[] { count3, "h1", new HtmlElement[] { count3[0], count3[2] } };
            yield return new object[] { count3, "H1", new HtmlElement[] { count3[0], count3[2] } };

            // Element does not exist
            yield return new object[] { count0, "no-such-element", new HtmlElement[0] };
            yield return new object[] { count1, "no-such-element", new HtmlElement[0] };
            yield return new object[] { count2, "no-such-element", new HtmlElement[0] };
            yield return new object[] { count2, "no-such-element", new HtmlElement[0] };
        }

        [Theory]
        [MemberData(nameof(Elements_Method_TestData))]
        public void Elements(HtmlElement[] elements, string tag, HtmlElement[] expected)
        {
            HtmlElement element = new HtmlElement("element", elements);
            if (tag == null)
            {
                Assert.Equal(expected, element.Elements().ToArray());
            }
            Assert.Equal(expected, element.Elements(tag).ToArray());
        }

        [Fact]
        public void Elements_IgnoresNodes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);

            Assert.Equal(new HtmlElement[] { element1, element2 }, parent.Elements());
        }

        [Fact]
        public void Elements_String_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element1");
            HtmlElement element3 = new HtmlElement("element2");

            HtmlElement element = new HtmlElement("element", element1, element2, element3);
            Assert.Equal(new HtmlElement[] { element1, element2 }, element.Elements("element1"));
            Assert.Equal(new HtmlElement[] { element1, element2 }, element.Elements("ELEMENT1"));
            Assert.Equal(new HtmlElement[] { element3 }, element.Elements("element2"));
        }

        [Fact]
        public void Elements_String_IgnoresNodes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);

            Assert.Equal(new HtmlElement[] { element1 }, parent.Elements("element1"));
        }

        [Fact]
        public void Elements_String_NoSuchTag_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("parent", new HtmlElement("element1"), new HtmlElement("element2"));
            Assert.Empty(element.Elements("no-such-tag"));
        }

        [Fact]
        public void Elements_String_NoChildren_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Empty(element.Elements(null));
            Assert.Empty(element.Elements("no-such-tag"));

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.Empty(element.Elements(null));
            Assert.Empty(element.Elements("no-such-tag"));
        }

        [Fact]
        public void FirstAttribute_HasAttributes_ReturnsExpected()
        {
            HtmlAttribute expected = new HtmlAttribute("attribute1");
            HtmlElement element = new HtmlElement("parent", expected, new HtmlAttribute("attribute2"));
            Assert.Equal(expected, element.FirstAttribute);
        }

        [Fact]
        public void FirstAttribute_NoAttributes_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.FirstAttribute);

            element.Add(new HtmlElement("element"));
            Assert.Null(element.FirstAttribute);
        }

        [Fact]
        public void FirstAttribute_LastAttribute_OneAttribute_ReturnsSame()
        {
            HtmlAttribute expected = new HtmlAttribute("attribute");
            HtmlElement element = new HtmlElement("parent", expected);
            Assert.Equal(expected, element.FirstAttribute);
            Assert.Equal(element.FirstAttribute, element.LastAttribute);
        }

        [Fact]
        public void FirstElement_HasElements_ReturnsExpected()
        {
            HtmlElement expected = new HtmlElement("head");
            HtmlElement element = new HtmlElement("parent", expected, new HtmlElement("element"));
            Assert.Equal(expected, element.FirstElement);
        }

        [Fact]
        public void FirstElement_NoElements_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.FirstElement);

            // Ignores attributes
            element.Add(new HtmlAttribute("attribute"));
            Assert.Null(element.FirstElement);

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.Null(element.FirstElement);
        }

        [Fact]
        public void FirstElement_LastElement_OneElement_ReturnsSame()
        {
            HtmlElement expected = new HtmlElement("element");
            HtmlElement element = new HtmlElement("parent", expected);
            Assert.Equal(expected, element.FirstElement);
            Assert.Equal(element.FirstElement, element.LastElement);
        }

        [Fact]
        public void FirstNode_Element_ReturnsExpected()
        {
            HtmlElement expected = new HtmlElement("head");
            HtmlElement element = new HtmlElement("parent", expected, new HtmlElement("element"));
            Assert.Equal(expected, element.FirstNode);
        }

        [Fact]
        public void FirstNode_Comment_ReturnsExpected()
        {
            HtmlComment expected = new HtmlComment("comment");
            HtmlElement element = new HtmlElement("parent", expected, new HtmlElement("element"));
            Assert.Equal(expected, element.FirstNode);
        }

        [Fact]
        public void FirstNode_NoNodes_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.FirstNode);

            // Ignores attributes
            element.Add(new HtmlAttribute("attribute"));
            Assert.Null(element.FirstNode);
        }

        [Fact]
        public void HasAttributes_HasAttributes_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("parent", new HtmlAttribute("attribute"));
            Assert.True(element.HasAttributes);
        }

        [Fact]
        public void HasAttributes_NoAttributes_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.False(element.HasAttributes);

            // Ignores elements
            element.Add(new HtmlElement("element"));
            Assert.False(element.HasAttributes);

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.False(element.HasAttributes);
        }

        [Fact]
        public void HasAttribute_NullName_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Throws<ArgumentNullException>("name", () => element.HasAttribute(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n ")]
        public void HasAttribute_InvalidName_ThrowsArgumentException(string name)
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Throws<ArgumentException>("name", () => element.HasAttribute(name));
        }

        [Fact]
        public void HasElements_HasElements_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("element", new HtmlElement("head"));
            Assert.True(element.HasElements);
        }

        [Fact]
        public void HasElements_NoElements_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.False(element.HasElements);

            // Ignores attributes
            element.Add(new HtmlAttribute("attribute"));
            Assert.False(element.HasElements);

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.False(element.HasElements);
        }

        [Fact]
        public void HasElement_NullTag_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Throws<ArgumentNullException>("tag", () => element.HasElement(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n ")]
        public void HasElement_InvalidName_ThrowsArgumentException(string tag)
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Throws<ArgumentException>("tag", () => element.HasElement(tag));
        }

        [Fact]
        public void IsEmpty_HasElements_ReturnsTrue()
        {
            // TODO: nodes
            HtmlElement element = new HtmlElement("parent", new HtmlElement("element"));
            Assert.False(element.IsEmpty);
        }

        [Fact]
        public void IsEmpty_HasAttributes_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("parent", new HtmlAttribute("attribute"));
            Assert.False(element.IsEmpty);
        }

        [Fact]
        public void IsEmpty_HasElementsAndAttributes_ReturnsTrue()
        {
            // TODO: nodes
            HtmlElement element = new HtmlElement("parent", new HtmlElement("element"), new HtmlAttribute("attribute"));
            Assert.False(element.IsEmpty);
        }

        [Fact]
        public void IsEmpty_HasNoNodesOrAttributes_ReturnsTrue()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.True(element.IsEmpty);
        }

        [Fact]
        public void LastAttribute_HasAttributes_ReturnsExpected()
        {
            HtmlAttribute expected = new HtmlAttribute("attribute2");
            HtmlElement element = new HtmlElement("parent", new HtmlAttribute("attribute1"), expected);
            Assert.Equal(expected, element.LastAttribute);
        }

        [Fact]
        public void LastAttribute_NoAttributes_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.LastAttribute);

            element.Add(new HtmlElement("element"));
            Assert.Null(element.LastAttribute);
        }

        [Fact]
        public void LastElement_HasElements_ReturnsExpected()
        {
            HtmlElement expected = new HtmlElement("element");
            HtmlElement element = new HtmlElement("parent", new HtmlElement("head"), expected);
            Assert.Equal(expected, element.LastElement);
        }

        [Fact]
        public void LastElement_NoElements_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.LastElement);

            // Ignores attributes
            element.Add(new HtmlAttribute("attribute"));
            Assert.Null(element.LastElement);

            // Ignores nodes
            element.Add(new HtmlComment("comment"));
            Assert.Null(element.LastElement);
        }

        [Fact]
        public void LastNode_Element_ReturnsExpected()
        {
            HtmlElement expected = new HtmlElement("element");
            HtmlElement element = new HtmlElement("parent", new HtmlElement("head"), expected);
            Assert.Equal(expected, element.LastNode);
        }

        [Fact]
        public void LastNode_Comment_ReturnsExpected()
        {
            HtmlComment expected = new HtmlComment("comment");
            HtmlElement element = new HtmlElement("parent", new HtmlElement("element"), expected);
            Assert.Equal(expected, element.LastNode);
        }

        [Fact]
        public void LastNode_NoNodes_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Null(element.LastNode);

            // Ignores attributes
            element.Add(new HtmlAttribute("attribute"));
            Assert.Null(element.LastNode);
        }

        [Fact]
        public void NextElement_Get_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3);

            Assert.Equal(element2, element1.NextElement);
            Assert.Equal(element3, element2.NextElement);
            Assert.Null(element3.NextElement);
        }

        [Fact]
        public void NextElement_NoParent_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Null(element.NextElement);
        }

        [Fact]
        public void NextElements_NoTag_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3);

            Assert.Equal(new HtmlElement[] { element2, element3 }, element1.NextElements());
            Assert.Equal(new HtmlElement[] { element3 }, element2.NextElements());
            Assert.Empty(element3.NextElements());
        }

        [Fact]
        public void NextElements_CustomTag_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element2");
            HtmlElement element4 = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3, element4);

            Assert.Equal(new HtmlElement[] { element2, element3 }, element1.NextElements("element2"));
            Assert.Equal(new HtmlElement[] { element2, element3 }, element1.NextElements("ELEMENT2"));
            Assert.Equal(new HtmlElement[] { element3 }, element2.NextElements("element2"));
            Assert.Equal(new HtmlElement[] { element4 }, element3.NextElements("element3"));
            Assert.Empty(element3.NextElements("element1"));
        }

        [Fact]
        public void NextElements_NoSuchTag_ReturnsEmpty()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3);

            Assert.Empty(element1.NextElements("element1"));
            Assert.Empty(element1.NextElements("element3"));
        }

        [Fact]
        public void NextElements_NoParent_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("parent");
            Assert.Empty(element.NextElements());
            Assert.Empty(element.NextElements("any"));
        }

        [Fact]
        public void NextElements_NoSiblings_ReturnsEmpty()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            parent.Add(element);
            Assert.Empty(element.NextElements());
            Assert.Empty(element.NextElements("any"));
        }

        [Fact]
        public void PreviousElement_Get_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("div", element1, element2, element3);

            Assert.Null(element1.PreviousElement);
            Assert.Equal(element1, element2.PreviousElement);
            Assert.Equal(element2, element3.PreviousElement);
        }

        [Fact]
        public void PreviousElement_NoParent_ReturnsNull()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Null(element.PreviousElement);
        }

        [Fact]
        public void PreviousElements_NoTag_ReturnsExpected()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement element3 = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3);

            Assert.Empty(element1.PreviousElements());
            Assert.Equal(new HtmlElement[] { element1 }, element2.PreviousElements());
            Assert.Equal(new HtmlElement[] { element2, element1 }, element3.PreviousElements());
        }

        [Fact]
        public void PreviousElements_CustomTag_ReturnsExpected()
        {
            HtmlElement first = new HtmlElement("element1");
            HtmlElement second = new HtmlElement("element2");
            HtmlElement third = new HtmlElement("element2");
            HtmlElement fourth = new HtmlElement("element3");
            HtmlElement parent = new HtmlElement("parent", first, second, third, fourth);

            Assert.Empty(first.PreviousElements("element3"));
            Assert.Equal(new HtmlElement[] { first }, second.PreviousElements("element1"));
            Assert.Equal(new HtmlElement[] { first }, second.PreviousElements("ELEMENT1"));
            Assert.Equal(new HtmlElement[] { second }, third.PreviousElements("element2"));
            Assert.Equal(new HtmlElement[] { third, second }, fourth.PreviousElements("element2"));
        }

        [Fact]
        public void PreviousElements_NoSuchTag_ReturnsEmpty()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlElement element2 = new HtmlElement("element1");
            HtmlElement element3 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, element2, element3);

            Assert.Empty(element3.PreviousElements("element2"));
            Assert.Empty(element3.PreviousElements("element3"));
        }

        [Fact]
        public void PreviousElements_NoParent_ReturnsEmpty()
        {
            HtmlElement element = new HtmlElement("element");
            Assert.Empty(element.PreviousElements());
            Assert.Empty(element.PreviousElements("any"));
        }

        [Fact]
        public void PreviousElements_NoSiblings_ReturnsEmpty()
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement element = new HtmlElement("element");
            parent.Add(element);
            Assert.Empty(element.PreviousElements());
            Assert.Empty(element.PreviousElements("any"));
        }

        public static IEnumerable<object[]> TryGetAttribute_TestData()
        {
            HtmlAttribute[] count0 = new HtmlAttribute[0];
            HtmlAttribute[] count1 = new HtmlAttribute[] { new HtmlAttribute("attribute1") };
            HtmlAttribute[] count2 = new HtmlAttribute[] { new HtmlAttribute("attribute1"), new HtmlAttribute("attribute2") };

            // Attribute exists
            yield return new object[] { count1, "attribute1", count1[0] };
            yield return new object[] { count1, "ATTRIBUTE1", count1[0] };
            yield return new object[] { count2, "attribute1", count2[0] };
            yield return new object[] { count2, "attribute2", count2[1] };
            yield return new object[] { count2, "ATTRIBUTE2", count2[1] };

            // No such attribute
            yield return new object[] { count0, "no-such-attribute", null };
            yield return new object[] { count1, "no-such-attribute", null };
            yield return new object[] { count2, "no-such-attribute", null };
        }

        [Theory]
        [MemberData(nameof(TryGetAttribute_TestData))]
        public void TryGetAttribute(HtmlAttribute[] attributes, string name, HtmlAttribute expected)
        {
            HtmlElement parent = new HtmlElement("element", attributes);

            HtmlAttribute attribute;
            Assert.Equal(expected != null, parent.TryGetAttribute(name, out attribute));
            Assert.Equal(expected, attribute);

            Assert.Equal(expected != null, parent.HasAttribute(name));
        }

        [Fact]
        public void TryGetAttribute_NullName_ThrowsArgumentNullException()
        {
            HtmlElement element = new HtmlElement("element");
            HtmlAttribute attribute = null;
            Assert.Throws<ArgumentNullException>("name", () => element.TryGetAttribute(null, out attribute));
            Assert.Null(attribute);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n ")]
        public void TryGetAttribute_InvalidName_ThrowsArgumentException(string name)
        {
            HtmlElement element = new HtmlElement("element");
            HtmlAttribute attribute = null;
            Assert.Throws<ArgumentException>("name", () => element.TryGetAttribute(name, out attribute));
            Assert.Null(attribute);
        }

        public static IEnumerable<object[]> TryGetElement_TestData()
        {
            HtmlElement[] count0 = new HtmlElement[0];
            HtmlElement[] count1 = new HtmlElement[] { new HtmlElement("element1") };
            HtmlElement[] count2 = new HtmlElement[] { new HtmlElement("element1"), new HtmlElement("element2") };

            // Element exists
            yield return new object[] { count1, "element1", count1[0] };
            yield return new object[] { count1, "ELEMENT1", count1[0] };
            yield return new object[] { count2, "element1", count2[0] };
            yield return new object[] { count2, "element2", count2[1] };
            yield return new object[] { count2, "ELEMENT2", count2[1] };

            // No such Element
            yield return new object[] { count0, "no-such-element", null };
            yield return new object[] { count1, "no-such-element", null };
            yield return new object[] { count2, "no-such-element", null };
        }

        [Theory]
        [MemberData(nameof(TryGetElement_TestData))]
        public void TryGetElement(HtmlElement[] elements, string tag, HtmlElement expected)
        {
            HtmlElement parent = new HtmlElement("element", elements);

            HtmlElement element;
            Assert.Equal(expected != null, parent.TryGetElement(tag, out element));
            Assert.Equal(expected, element);

            Assert.Equal(expected != null, parent.HasElement(tag));
        }

        [Fact]
        public void TryGetElement_IgnoresNodes()
        {
            HtmlElement element1 = new HtmlElement("element1");
            HtmlComment comment = new HtmlComment("comment");
            HtmlElement element2 = new HtmlElement("element2");
            HtmlElement parent = new HtmlElement("parent", element1, comment, element2);

            HtmlElement element;
            Assert.False(parent.TryGetElement("comment", out element));
            Assert.Null(element);
        }

        [Fact]
        public void TryGetElement_NullTag_ThrowsArgumentNullException()
        {
            HtmlElement parent = new HtmlElement("element");
            HtmlElement element = null;
            Assert.Throws<ArgumentNullException>("tag", () => parent.TryGetElement(null, out element));
            Assert.Null(element);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n ")]
        public void TryGetElement_InvalidTag_ThrowsArgumentException(string tag)
        {
            HtmlElement parent = new HtmlElement("element");
            HtmlElement element = null;
            Assert.Throws<ArgumentException>("tag", () => parent.TryGetElement(tag, out element));
            Assert.Null(element);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" \r \t \n")]
        public void TryGetAttribute_WhitespaceName_ThrowsArgumentException(string name)
        {
            HtmlElement element = new HtmlElement("element");
            HtmlAttribute attribute = null;
            Assert.Throws<ArgumentNullException>("name", () => element.TryGetAttribute(null, out attribute));
            Assert.Null(attribute);
        }
    }
}
