var serviceWorker = {
    Post: (parameters) => {
        var returnValue = "";
        $.ajax({
            url: parameters.url,
            data: parameters.data,
            method: "POST",
            success: (response) => {
                returnValue = response;
            },
            error: (xhr) => {
                console.log(xhr);
            }
        })
        return returnValue;
    }
}


var services = {
    CustomerChange: (id) => {
        var parameters = {
            url: urls.URLCustomerDetails,
            data: {
                //selectedUserName: $('#changeCustomersUser').val(),
                id: id,
                userName: $('#userName').val(),
                email: $('#email').val(),
                title: $('#title').val(),
                city: $('#city').val(),
                companyName: $('#companyName').val(),
                customerUserID: $('#customerUserID').val()
            }
        };
        var result = serviceWorker.Post(parameters);
        setTimeout(() => { window.location.href = urls.URLGetCustomer; }, 1000)

    }
}