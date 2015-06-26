/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
  var domElement = (function () {
    var invalidTypePattern = /[^\w]/g,
      invalidNamePattern = /[^\w\-]/g;

    function removeAttributeByName(obj, value) {

      if (!(obj.attributes.hasOwnProperty(value))) {
        throw new Error('Dom element doesn\'t have attribute ' + value);
      }
      delete obj.attributes[value];
    }

    function validateAttributeName(value) {
      if (value === undefined) {
        throw new Error('Attribute name is undefined');
      }
      if ((typeof (value) !== 'string')) {
        throw new Error('Attribute name must be string');
      }
      if (!value.length) {
        throw new Error('Attribute name must be not empty string');
      }
      if ((invalidNamePattern.test(value))) {
        throw new Error('Dom element type have some invalid characters');
      }
      return value;
    }

    function validateType(value) {
      if (value === undefined) {
        throw new Error('Dom element type is undefined');
      }
      if (typeof (value) !== 'string') {
        throw new Error('Dom element type value must be string');
      }
      if (!value.length) {
        throw new Error('Invalid type');
      }
      if ((invalidTypePattern.test(value))) {
        throw new Error('Dom element type have some invalid characters');
      }
      return value;
    }

    function validateContent(value) {
      if (typeof (value) !== 'string') {
        throw new Error('Dom element content value must be string');
      }
      return value;
    }

    var domElement = {
      init: function (type) {
        this.type = type;
        this.attributes = [];
        this.childrens = [];
        this.content = '';

        return this;
      },
      appendChild: function (child) {
        if (typeof child === 'object') {
          child.parent = this;
          this.childrens.push(child);
        } else if (typeof child === 'string') {
          this.childrens.push(child);
        }
        return this;
      },
      addAttribute: function (name, value) {
        var validName = validateAttributeName(name);
        this.attributes[validName] = value;
        return this;
      },
      removeAttribute: function (attribute) {
        removeAttributeByName(this, attribute);
        return this;
      },
      get attributes() {
        return this._attributes;
      },
      set attributes(value) {
        this._attributes = value;
      },
      get innerHTML() {
        var i, keys, html = '<' + this.type;

        keys = Object.keys(this.attributes);
        keys.sort();

        for (i = 0; i < keys.length; i += 1) {
          html += (' ' + keys[i] + '="' + this.attributes[keys[i]] + '"');
        }

        if (this.childrens.length) {
          html += '>';
          for (i = 0; i < this.childrens.length; i += 1) {
            if(typeof(this.childrens[i]) === 'string'){
              html += this.childrens[i];
              continue;
            }
            html += this.childrens[i].innerHTML;
          }
        } else {
          html += '>' + this.content;
        }

        html += '</' + this._type + '>';
        return html;
      },
    };

    Object.defineProperty(domElement, 'type', {
      get: function () {
        return this._type;
      },
      set: function (value) {
        this._type = validateType(value);
        return this;
      }
    });

    Object.defineProperty(domElement, 'content', {
      get: function () {
        return this._content;
      },
      set: function (value) {
        if (this._childrens.length === 0) {
          this._content = validateContent(value);
        }
        else {
          this._content = '';
        }
        return this;
      }
    });

    Object.defineProperty(domElement, 'childrens', {
      get: function () {
        return this._childrens;
      },
      set: function (value) {
        this._childrens = value;
        return this;
      }
    });

    Object.defineProperty(domElement, 'parent', {
      get: function () {
        return this._parent;
      },
      set: function (value) {
        this._parent = value;
        return this;
      }
    });

    return domElement;
  } ());
  return domElement;
}
module.exports = solve;
