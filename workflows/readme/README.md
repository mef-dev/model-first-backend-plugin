This BSS.Entitties (formely called Natec.Entities) NuGet implements a package for MEF.DEV platform and provides access to the Shared Information and Data Model (SID) of the Telecom BSS domain, was developed based on ITUT (M.3050) of the TM Forum organization and is the basis for the integration of OSS/BSS (Operation Support System/Business Support System) through their use of a unified information model to provide data.

Before you contribute, please read through the [Creation of Backend package from the template](https://mef.dev/dev_guides/first_backend_plugin.md)

The SID-model is part of the MEF.DEV Reference Architecture (reference - optimized scheme of actions applicable in different situations - replicated) for the classification and description of all business processes of the service operator with varying levels of detail. The Reference Architecture is a template for organizing product development process management. It provides a starting point for reorganizing internal processes, managing interaction with 3rd partners, and entering into standard working agreements with other development teams of joint products (bundles).

The Natec.Entities SID-model gives independent developers open access to the main operational processes of consumer support, such as Fulfilment, Assurance, and Billing (FAB).

[BSS.Entities diagram](https://raw.githubusercontent.com/mef-dev/model-first-backend-plugin/main/workflows/readme/Unibill.Entities.svg)

The core of the SID-model is the set of Actions (atomic part of the process flow) allocated based on the experience of real projects in the Telecom BSS domain. The Telecom provider can build the custom flow based on the existing sets of Actions, which will allow, due to their combination and unification, to implement their specific “end-to-end” scenario with the help of which these processes ensure the implementation of the purpose of the company's business activities.

### Why is the Telecom BSS Domain SID Model needed?

+ provides a standard structure, terminology, and classification scheme for describing business processes and their building blocks
+ offers a framework for applying typical business process design principles across the enterprise.
+ provides a framework for understanding and managing an application portfolio in terms of business process requirements.
+ enables the creation of holistic, high-quality workflows of end-to-end processes to reuse existing processes and systems, including reducing costs and increasing efficiency.

### When will Telecom BSS Domain SID Model Help? 

The SID model diagram is a part of the business analysis of existing product management processes in an organization and the development of new services or products. It can help you identify processes that provide the same business function, eliminate possible duplication, detect gaps, accelerate new product development, and reduce inconsistencies. The SID model allows you to assess the significance of individual processes used in an organization to evaluate the impact when a new process or product is launched. The SID model of BSS.Entities, as part of the MEF.DEV Reference Architecture simplifies relationships with partners in product development, as it allows you to identify and standardize the processes used when interacting with them. Likewise, you can place the critical processes used in customer interactions and assess whether these processes are performing as expected by the end customers.

[XML Schema of SID-model](https://raw.githubusercontent.com/mef-dev/model-first-backend-plugin/main/workflows/readme/sid.xsd) ![XML Schema of SID-model](https://raw.githubusercontent.com/mef-dev/model-first-backend-plugin/main/workflows/readme/xsd.png)
