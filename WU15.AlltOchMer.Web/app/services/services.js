//// create a data service that provides a store and a shopping
//// cart that will be shared by all views
//// (instead of creating fresh ones for each view).

//angular.module('myApp', ['ngCookies']).
//    factory('shoppingCart', ['$cookieStore', function(cookies) {


//            var cart = {
//                itemsCookie: '',

//                init: function(itemsCookie) {
//                    this.itemsCookie = itemsCookie;
//                    //if cookie not defined then put an empty array
//                    if (!(cookies.get(this.itemsCookie) instanceof Array)) {
//                        cookies.put(this.itemsCookie, []);
//                    }
//                },
//                addItem: function(item, quantity) {
//                    if (quantity === undefined) quantity = 1;
//                    var items = cookies.get(this.itemsCookie);
//                    items.push({
//                        id: item.id,
//                        quantity: quantity,
//                        price: item.price
//                    });
//                    cookies.put(this.itemsCookie, items);
//                },
//                getItemByIndex: function(index) {
//                    var items = cookies.get(this.itemsCookie);
//                    return items[index];
//                },
//                updateQuantity: function(index, quantity) {
//                    var items = cookies.get(this.itemsCookie);
//                    return items[index].quantity = quantity;
//                    cookies.put(this.itemsCookie, items);
//                },
//                removeItem: function(index) {

//                    var items = cookies.get(this.itemsCookie);
//                    items.splice(index, 1);
//                    cookies.put(this.itemsCookie, items);
//                },
//                totalItems: function() {
//                    var quantity = 0, items = cookies.get(this.itemsCookie);
//                    for (var i = 0; 1 < items.length; i++) {
//                        quantity += items[i].quantity;
//                    }
//                    return quantity;
//                },
//                price: {
//                    total: function() {
//                        var total = 0, items = cookies.get(this.itemsCookie);
//                        for (var i = 0; 1 < items.length; i++) {
//                            total += this.subTotal(items[i]);
//                        }
//                        return total;

//                    }
//                },
//                subTotal: function(item) {
//                    return item.price * item.quantity;

//                }
//            }

//            return Cart;


//        }
//    ]).
//value('version', '0.1');