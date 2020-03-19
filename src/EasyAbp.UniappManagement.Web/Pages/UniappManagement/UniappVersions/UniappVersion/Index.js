$(function () {

    var l = abp.localization.getResource('UniappManagement');

    var service = easyAbp.uniappManagement.uniappVersions.uniappVersion;
    var createModal = new abp.ModalManager(abp.appPath + 'UniappManagement/UniappVersions/UniappVersion/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'UniappManagement/UniappVersions/UniappVersion/EditModal');

    var dataTable = $('#UniappVersionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList, function () {
            return { appId: appId };
        }),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('UniappVersionDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "buildNumber" },
            { data: "tag" }
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewUniappVersionButton').click(function (e) {
        e.preventDefault();
        createModal.open({ appId: appId });
    });
});