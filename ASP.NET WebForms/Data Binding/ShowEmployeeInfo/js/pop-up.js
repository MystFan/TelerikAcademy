/// <reference path="jquery.min.js"/>
(function () {
    'use strict';
    
    $(document).ready(function () {
        let $container = $('#popUp');
        $container.hide();

        let $overlay = $('<div/>').attr('id', 'overlay');
        $('body').append($overlay);
        $overlay.hide();

        $('#ListViewEmployees_tblContacts').on('mouseover', 'tr', function (e) {
            let $this = $(this);

            if ($this.hasClass('header')) {
                return;
            }

            let x = e.pageX;
            let y = e.pageY;

            $container.empty();
            $container.css('z-index', 1000);
            $container.css('position', 'absolute');
            $container.css('left', x);
            $container.css('top', y);

            let properties = ['First Name', 'Last Name', 'job', 'Birth date', 'Hire date', 'City', 'Country'];

            let spans = $this.find('span');

            for (var i = 0; i < properties.length; i++) {
                let $strong = $('<strong/>');
                let $label = $('<label/>');
                $label.text($(spans[i]).html());
                $strong.text(properties[i]);

                let $div = $('<div/>');
                $div.append($strong).append($label);
                $container.append($div);
            }

            $container.show();
        })

        $('#ListViewEmployees_tblContacts').on('mouseout', 'tr', function (e) {
            $container.hide();
        })
    });
}())