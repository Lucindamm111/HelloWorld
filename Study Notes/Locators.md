### Locators 



IDs, input names and class names are the easiest locators to use.





**CSS Selectors:**



Tag name: div

Class name: .result

Tag and class name: div.result

ID: #search\_form\_input

Descendants: div.cw div.result

Direct children: li.zcm\_\_item > a

Multiple selectors: ol, ul

Attribute existence: \[style]

Tag with attribute: div\[style]

Tag with attribute equality: a\[data-zci-link='images']

Tag with attribute contains: div\[class\*='results']

Logical not pseudoclass: div.result:not(.result--more)

Nth child pseudoclass: div.result:nth-child(5)



Other 3 Locators



* Link text locators match “a” elements that equal the given text.
* Partial Link Text Locators //a\[contains(., ‘\_value\_’)]. (contains instead of equals the value)
* Tag locators- return all elements that use a given tag



**Playwright offers a set of built-in locators**



page.get\_by\_role() to locate by explicit and implicit accessibility attributes.

page.get\_by\_text() to locate by text content.

page.get\_by\_label() to locate a form control by associated label's text.

page.get\_by\_placeholder() to locate an input by placeholder.

page.get\_by\_alt\_text() to locate an element, usually image, by its text alternative.

page.get\_by\_title() to locate an element by its title attribute.

page.get\_by\_test\_id() to locate an element based on its data-testid attribute (other attributes can be configured).





Test\_Id is an easy locator just add "data-tested"

by\_text value



**Preferred locators**



Test ID using a data- attribute

ID (if the ID is unique on the page)

Input name (if the name is unique on the page)

Class name

Text value

CSS selector

XPath without text or indexing

Link text or partial link text

XPath with text and/or indexing



**Tools for creating Locators**

# Chrome DevTools can generate CSS selectors and XPaths for any element on the page.

Playwright has a test generator that will let you record sessions in a browser and then generate a script with all your interactions.

SelectorsHub is a popular tool for generating CSS selectors and XPaths.

Many codeless automation tools provide record-and-playback functionality that will figure out locators for you. Many of them include self-healing capabilities as well, so that your tests won’t break as your pages evolve.

