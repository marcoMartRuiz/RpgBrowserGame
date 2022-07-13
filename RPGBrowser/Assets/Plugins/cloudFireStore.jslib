mergeInto(LibraryManager.library, {

    GetJson: function (collectionPath, documentId, objectName, callback, fallback) {
        var parsedPath = Pointer_stringify(collectionPath);
        var parsedId = Pointer_stringify(documentId);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {
           firebase.firestore().collection(parsedPath).doc(parsedId).get().then(function (doc) {
                if (doc.exists) {
                    unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, JSON.stringify(doc.data()));
                } else {
                    unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "null");
                }
            }).catch(function(error) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
            });
        } 
        catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },
                                                                                                                                   
    CreateUserWithEmailAndPassword: function (email, password, objectName, callback, fallback) {                               
        var parsedEmail = Pointer_stringify(email);                                                                            
        var parsedPassword = Pointer_stringify(password);                                                                      
        var parsedObjectName = Pointer_stringify(objectName);                                                                  
        var parsedCallback = Pointer_stringify(callback);                                                                      
        var parsedFallback = Pointer_stringify(fallback);                                                                      
                                                                                                                               
        try {                                                                                                                                                                                               firebase.auth().createUserWithEmailAndPassword(parsedEmail, parsedPassword).then(function (unused) {               
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "Success: signed up for " + parsedEmail);   
            }).catch(function (error) {                                                                                        
                unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
                });                                                                                                                                                                                    
        } 
        catch (error) {                                                                                                      
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));                                                             
        }                                                                                                                      
    },   

    SignInWithEmailAndPassword: function (email, password, objectName, callback, fallback) {
        var parsedEmail = Pointer_stringify(email);
        var parsedPassword = Pointer_stringify(password);
        var parsedObjectName = Pointer_stringify(objectName);
        var parsedCallback = Pointer_stringify(callback);
        var parsedFallback = Pointer_stringify(fallback);

        try {
            firebase.auth().signInWithEmailAndPassword(parsedEmail, parsedPassword).then(function (unused) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedCallback, "Success: signed in for " + parsedEmail);
            }).catch(function (error) {
                unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
            });
        }
        catch (error) {
            unityInstance.Module.SendMessage(parsedObjectName, parsedFallback, JSON.stringify(error, Object.getOwnPropertyNames(error)));
        }
    },
    

    

 

});