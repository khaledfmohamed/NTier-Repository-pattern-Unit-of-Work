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
## Repository project:
 This project is a practical example for microsft repository pattern , with this project all database or storage operation will be here That means that any query or ADO EnttiyFramwork operation will be here and will not be in any other project.
 
 
