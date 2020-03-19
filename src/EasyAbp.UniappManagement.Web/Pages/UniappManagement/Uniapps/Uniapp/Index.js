$(function () {

    var l = abp.localization.getResource('UniappManagement');

    var service = easyAbp.uniappManagement.uniapps.uniapp;
    var createModal = new abp.ModalManager(abp.appPath + 'UniappManagement/Uniapps/Uniapp/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'UniappManagement/Uniapps/Uniapp/EditModal');

    var dataTable = $('#UniappTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('UniappVersion'),
                                visible: abp.auth.isGranted('UniappManagement.UniappVersion'),
                                action: function (data) {
                                    window.location.href = abp.appPath + "UniappManagement/UniappVersions/UniappVersion?appId=" + data.record.id
                                }
                            },
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('UniappDeletionConfirmationMessage', data.record.id);
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
            { data: "name" },
            { data: "description" },
            { data: "iconImageUrl" },
            { data: "isAvailable" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewUniappButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});