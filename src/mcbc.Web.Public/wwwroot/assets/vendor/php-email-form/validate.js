/**
* PHP Email Form Validation - v3.2
* URL: https://bootstrapmade.com/php-email-form/
* Author: BootstrapMade.com
*/
(function () {
    "use strict";
    const API_BASE_URI = 'https://localhost:44311';


    let forms = document.querySelectorAll('.php-email-form');


    forms.forEach(function (e) {
        e.addEventListener('submit', function (event) {
            event.preventDefault();

            let thisForm = this;

            let action = thisForm.getAttribute('action');
            let recaptcha = thisForm.getAttribute('data-recaptcha-site-key');

            action = `${API_BASE_URI}/api/services/app/NGO/create`;
            if (!action) {

                displayError(thisForm, 'The form action property is not set!')
                return;
            }
           
            thisForm.querySelector('.loading').classList.add('d-block');
            thisForm.querySelector('.error-message').classList.remove('d-block');
            thisForm.querySelector('.sent-message').classList.remove('d-block');

            let formData = new FormData(thisForm);

            formData = {

                "title": formData.get('subject'),
                "charityNumber": "9099",
                "email": formData.get('email'),
                "phoneNumber": "923838383",
                "description": formData.get('message'),
                "logo": "/logo.jpg",

                "contactPersonName": formData.get('name'),
                "contactPersonPhone": "93838338",
                "contactPersonEmail": "hamidgul@hotmail.com",

                "website": "www",
                "currency": "USD",
                "currencySign": "$",
                "address1": "test1",
                "address2": "test2",
                "address3": "test2",
                "city": "atd",
                "county": "Over",
                "postalCode": "322423",
                "country": "UK",
                "latitude": 0,
                "longitude": 0,
                "geoLocation": null,

            }

            if (recaptcha) {
                if (typeof grecaptcha !== "undefined") {
                    grecaptcha.ready(function () {
                        try {
                            grecaptcha.execute(recaptcha, { action: 'php_email_form_submit' })
                                .then(token => {
                                    formData.set('recaptcha-response', token);
                                    php_email_form_submit(thisForm, action, formData);
                                })
                        } catch (error) {
                            displayError(thisForm, error)
                        }
                    });
                } else {
                    displayError(thisForm, 'The reCaptcha javascript API url is not loaded!')
                }
            } else {
                submitForm(thisForm, action, formData);
            }
        });
    });

    function submitForm(thisForm, action, formData) {
        console.log(action);
        fetch(action, {
            method: 'POST',
            headers: {
                'Accept': 'text/plain',
                'Content-Type': 'application/json-patch+json'
            },
            body: JSON.stringify(formData)
        })
            .then(response => {
                console.log(response)
                if (response.ok) {
                    return response.json()
                } else {
                    throw new Error(`${response.status} ${response.statusText} ${response.url}`);
                }
            })
            .then(data => {
                const { success, error, result } = data;
               
                console.dir(result);
                thisForm.querySelector('.loading').classList.remove('d-block');
                if (success == true) {
                    thisForm.querySelector('.sent-message').classList.add('d-block');
                    thisForm.reset();
                } else {
                    throw new Error(error ? error : 'Form submission failed and no error message returned from: ' + action);
                }
            })
            .catch((error) => {
                displayError(thisForm, error);
            });
    }

    function displayError(thisForm, error) {
        thisForm.querySelector('.loading').classList.remove('d-block');
        thisForm.querySelector('.error-message').innerHTML = error;
        thisForm.querySelector('.error-message').classList.add('d-block');
    }

})();
