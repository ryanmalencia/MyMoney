if (!String.prototype.supplant) {
    String.prototype.supplant = function (o) {
        return this.replace(/{([^{}]*)}/g,
            function (a, b) {
                var r = o[b];
                return typeof r === 'string' || typeof r === 'number' ? r : a;
            }
        );
    };
}

$(function () {

	var control = $.connection.ActivityHub, $infoTable = $('#infoTable'), rowTemplate = '<tr data-symbol="{Name}" style="background-color:{Color}"><td width="10%">{ID}</td><td width="30%">{Account}</td><td width="30%">{Description}</td><td class="view" width="20%">{Date}</td></tr>';
	$infoTableBody = $infoTable.find('tbody');

	function formatInfo(info) {
		var status = 'Idle';
		var color = '#ffffff';

		if (info.Is_Dead == 1) {
			status = 'Dead';
			color = '#ff0000';
		}
		else if (info.Running_Job == 1) {
			status = 'Running Job';
			color = '#00ff00';
		}
		else if (info.Running_Job == 0 && info.Sent_Job == 0 && info.job === null) {
			status = 'Idle';
			color = '#ffffff';
		}

		return $.extend(info, {
			Name: info.Name,
			Running: status,
			ID: info.AgentID,
			Color: color,
		});
	}

	function init() {
		$.getJSON('http://10.0.0.136:4000/api/activity/getall/', function (data) {
			var obj = JSON.parse(data);
			$infoTableBody.empty();
			$.each(obj.Agents, function () {
				var info = formatInfo(this);
				var row = rowTemplate.supplant(info);
				$infoTableBody.append(row);
			});
		});
	}

	control.client.updateRunning = function (name, job) {
		var $therow = $infoTableBody.find('tr[data-symbol=' + name + ']');
		$therow[0].style.backgroundColor = '#00FF00';
		$therow[0].cells[2].innerHTML = 'Running Job ' + job;
	}

	control.client.updateIdle = function (name) {
		var $therow = $infoTableBody.find('tr[data-symbol=' + name + ']');
		$therow[0].style.backgroundColor = '#FFFFFF';
		$therow[0].cells[2].innerHTML = 'Idle';
	}

	control.client.updateDead = function (name) {
		var $therow = $infoTableBody.find('tr[data-symbol=' + name + ']');
		$therow[0].style.backgroundColor = '#FF0000';
		$therow[0].cells[2].innerHTML = 'Dead';
	}

	control.client.updateInformation = function (info) {
		var displayInfo = formatInfo(info),
            $row = $(rowTemplate.supplant(displayInfo));
		var $therow = $infoTableBody.find('tr[data-symbol=' + info.Name + ']');
		if ($therow[0] == null) {
			$infoTableBody.append(rowTemplate.supplant(info));
		}
	}

	control.client.addMachine = function (info) {
		var displayInfo = formatInfo(info),
            $row = $(rowTemplate.supplant(displayInfo));
		var $therow = $infoTableBody.find('tr[data-symbol=' + info.Name + ']');
		if ($therow[0] == null) {
			$infoTableBody.append(rowTemplate.supplant(info));
		}
	}

	control.client.deleteAgent = function (name) {
		var $therow = $infoTableBody.find('tr[data-symbol=' + name + ']');
		if ($therow[0] != null) {
			$therow[0].parentNode.removeChild($therow[0]);
		}
	}

	$.connection.hub.start().done(init);
});