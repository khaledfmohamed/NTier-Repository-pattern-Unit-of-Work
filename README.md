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

 
