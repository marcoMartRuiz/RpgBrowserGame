mergeInto(LibraryManager.library, {

     GetJSON: function(path, objectName, callback, fallback) {
        var parsedPath = Pointer_stringify(path);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {

            firebase.database().ref(parsedPath).once('value').then(function(snapshot) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, JSON.stringify(snapshot.val()));
            });

        } catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },
                              PostJSON: function(path, value, objectName, callback, fallback) {
        var parsedPath = Pointer_stringify(path);
        var parsedValue = Pointer_stringify(value);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {

            firebase.database().ref(parsedPath).set(JSON.parse(parsedValue)).then(function(unused) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "Success: " + parsedValue + " was posted to " + parsedPath);
            });

        } catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },

    UpdateJSON: function(path, value, objectName, callback, fallback) {
        var parsedPath = Pointer_stringify(path);
        var parsedValue = Pointer_stringify(value);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {

            firebase.database().ref(parsedPath).update(JSON.parse(parsedValue)).then(function(unused) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "Success: " + parsedValue + " was updated in " + parsedPath);
            });

        } catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },

    DeleteJSON: function(path, objectName, callback, fallback) {
        var parsedPath = Pointer_stringify(path);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {

            firebase.database().ref(parsedPath).remove().then(function(unused) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "Success: " + parsedPath + " was deleted");
            });

        } catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },

    
    

    

 

});