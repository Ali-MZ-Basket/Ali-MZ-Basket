!function(t){function e(o){if(i[o])return i[o].exports;var s=i[o]={i:o,l:!1,exports:{}};return t[o].call(s.exports,s,s.exports,e),s.l=!0,s.exports}var i={};e.m=t,e.c=i,e.d=function(t,i,o){e.o(t,i)||Object.defineProperty(t,i,{configurable:!1,enumerable:!0,get:o})},e.n=function(t){var i=t&&t.__esModule?function(){return t.default}:function(){return t};return e.d(i,"a",i),i},e.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},e.p="/assets/",e(e.s=66)}({66:function(t,e){Ext.define("XERO.tip.PointerTip",{extend:"Ext.Tip",autoHide:!1,border:!1,closable:!1,shadow:!1,pointerHeight:5,cls:"x-pointer-tip",initComponent:function(){this.color||this.addClass(this.getTipColorClassName("black")),this.showAbove&&this.addClass("pointer-showabove"),this.callParent(arguments)},setColor:function(t){["black","red","white"].forEach(function(t){this.removeClass(this.getTipColorClassName(t))},this),this.addClass(this.getTipColorClassName(t))},getTipColorClassName:function(t){return["x-",t,"-tip"].join("")},show:function(t,e){var i,o=this.target,s=o.getXY?o.getXY():o.getPosition(),n=t?s[0]+t:s[0],r=e?s[1]+e:s[1],a=o.getHeight(),h=o.getWidth(),l=this.width,c=this.height,p=n+h/2-l/2;i=this.showAbove?c?r-this.pointerHeight-c:r-2*a-this.pointerHeight-a:r+a+this.pointerHeight,this.showAt([p,i])}})}});