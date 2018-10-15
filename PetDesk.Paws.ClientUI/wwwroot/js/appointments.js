let connection = null;

setupConnection = () => {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("https://localhost:44399//appointmenthub")
        .build();


    connection.on("ReceiveAppointment", function (appointment) {
        // Find a <table> element with id="ReqAptTable":
        var table = document.getElementById("ReqAptTable");

       
        // Create an empty <tr> element and add it to the 1st position of the table:
        var row = table.insertRow(1);

        // Insert new cells (<td> elements) at the 1st and 2nd position of the "new" <tr> element:
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);
        var cell6 = row.insertCell(5);

        // Add some text to the new cells:
        cell1.innerHTML = appointment.clientid;
        cell2.innerHTML = appointment.patientid;
        cell3.innerHTML = appointment.appointmenttype;
        cell4.innerHTML = appointment.requestdate;

        var confirmtTag = document.createElement('a');
        confirmtTag.innerHTML = "Confirm Appointment";
        confirmtTag.id = "confTag";
        cell5.appendChild(confirmtTag);

        var reSchTag = document.createElement('a');
        reSchTag.innerHTML = "Reschedule Appointment";
        confirmtTag.id = "reshTag";
        cell6.appendChild(reSchTag);

      

        document.getElementById("confTag").onclick = function () {
            // add code here that removes the row and adds it to the 
        }

        document.getElementById("reshTag").onclick = function () {
            // add code here that removes row and confirms a reschedule has been sent
        }
    }
    );

    connection.on("finished", function () {
        connection.stop();
    }
    );

    connection.start()
        .catch(err => console.error(err.toString()));
};

setupConnection();