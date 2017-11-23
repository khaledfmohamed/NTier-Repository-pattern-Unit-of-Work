# NTier
Here I will present practical application on N-tier solution using C# and how model and messages (alerts) pass between layers.
## Structure Components:
The project solution consist of :
 - Model (NTierModel).
 - Message tube (MessageTube).
 - Repository (NTierRepository)
 - Bussinse Logic layer (NTierBL)
 - UI (NTier)
 
## The Main Idea:
The mean two points that we target from this architecture are:
  - Decoupling.
  - No repeated code.
  - Handle system messages from bottom(Repository) to top (UI).
  
## System Diagram:
![Diagram](https://github.com/khaledfmohamed/NTier/blob/master/NTier.png?raw=true)

## Model project:
 This project contain model class which will be passed between layers carring data.
The model class contain only properties with no methods just validation attributes on each property as need.
## Repository project(NTierRepository):
 This project is a practical example for ![Microsft repository pattern](https://msdn.microsoft.com/en-us/library/ff649690.aspx) , with this project all database or storage operation will be here , That mean that any query or ADO EnttiyFramwork operation will be here and will not be in any other project.
 ### Repository Components:
  - IRepository : Interface thet contain most common method like (GetAll() , Get() , Remove() , ..............)
  - RepositoryBase : Class Inherit IRepository to implement most common methods.
  - IProjectRepository : Interface Inherit IRepository to add the most need for specfic model which is here called project (Will be                                repeated for every model).
  - ProjectRepository : Class Inherit RepositoryBase and implement IProjectRepository (Will be repeated for every model).
  - IUnitOfWork : The Interface which is reponsable about the declaration of methods and properties need for opening and closing                           transaction and dispose any open resource.  
  - UnitOfWork : Class Inherit IUnitOfWork.
  - RepositoryException : this type of exception with be raised due to any exception occure in Repository project to be hanndled in         bussinse layer and send it to UI through MessageTube project.
    This class with carry exception message and code.
    The code property allow developer to take any expected exception code to check by this code in bussinse layer and return readable       message to user in UI.
   
   
   ![Diagram](https://github.com/khaledfmohamed/NTier/blob/master/ReprositoryException.png?raw=true)

Note : IUnitOfWork will be the communication point with bussinse layer.
## Bussins layer (NTierBLL):
Contain Bussinse or service objects which contain methods for bussinse logic and bussinse validation.
This methods will be called by UI (ViewModel , Controller , .....).
UI will call bussinse object throught Bussinse context object which is resposible about bussinse object intiation and the flow of messages (alerts) from bussinse logic to UI.

![Diagram](https://github.com/khaledfmohamed/NTier/blob/master/BussinseContext.png?raw=true)

## MessageTube:
This project contain interfaces and class for message solution.
This solution provide an index class called MessageList which will be intiated by BussniseContext object and any bussinse method will right to it.
UI will use messageList object to get user alerts.


 
 
 
 
