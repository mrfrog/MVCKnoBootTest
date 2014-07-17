var pageSelected = 0;
jQuery(document).ready(function () {
    ko.applyBindings(indexVM);
    indexVM.loadOrders(pageSelected);
    indexVM.createPagination();
});


var indexVM = {
    Items: ko.observableArray([]),
    PageIndex: ko.observable(),
    PageSize: ko.observable(),
    TotalResults: ko.observable(),
    TotalPages: ko.observable(),

//    paginated : ko.computed(function() {
//        var first = PageIndex * PageSize;
//        return Items.slice(first, first + PageSize);
//    }),

//    hasPrevious : ko.computed(function() {
//        return PageIndex !== 0;
//    }),

//    hasNext : ko.computed(function() {
//        return PageIndex !== TotalPages;
//}),
//    next : function() {
//        if(PageSize < TotalPages) {
//            PageIndex = PageIndex +1;
//    }
//},
	
//previous: function() {
//    if(PageIndex != 0) {
//        PageIndex = PageIndex -1;
//    }
    //},
    // Lets create pagination for this data
    createPagination: function () {
        $("#paginationHolder").pagination({
            pages: this.TotalPages(),
            itemsOnPage: this.PageSize(),
            currentPage: this.PageIndex(),
            cssStyle: 'pagination',
            onPageClick: this.loadOrders // fires when a page is clicked 
        })
    },

    loadOrders: function (pageSelected) {
        var self = this;
        //Ajax Call Get All order
        $.ajax({
            type: "GET",
            url: 'api/OrderApi/',
            data: { pageIndex: pageSelected },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                //Put the response in ObservableArray
                self.PageIndex(data.PageIndex);
                self.PageSize(data.PageSize);
                self.TotalResults(data.TotalResults);
                self.TotalPages(data.TotalPages);
                self.Items(data.Items); //Put the response in ObservableArray
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    }
};

function PageIndex(data) {
    pageSelected = this.PageIndex;
    this.PageIndex = ko.observable(data);
}

function PageSize(data) {
    this.PageSize = ko.observable(data);
}

function TotalResults(data) {
    this.TotalResults = ko.observable(data);
}

function TotalPages(data) {
    this.TotalPages = ko.observable(data);
}

function Items(data) {
    this.Items = ko.observable(data);
}

