module.exports = function (context, myQueueItem) {

    context.log('QueueTriggerJS1 processing work item', myQueueItem);

    context.bindings.outputQueueItem = [];

    for (i=0; i<myQueueItem.scale; i++)
    {
        context.bindings.outputQueueItem.push(myQueueItem.id + "_" + i);                
    }


    context.done();
};