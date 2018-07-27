/*
    Orris Disney II
    C# Inventory Project
    July 2018
    
    Definition of a Model
    The model represents the data, and does nothing else. The model does NOT depend on the controller or the view. 
    The view displays the model data, and sends user actions (e.g. button clicks) to the controller.

    This is for the the Item Type part of the project.    This is where you setup what data we are gathering for the Item Type class.   
    This is just setup as a standard table.   The One to many relationship is setup in the Item Model.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class ItemType
    {
        public int ItemTypeId { get; set; }
        public string ItemTypeDisplayName { get; set; }
        public string ItemTypeNotes { get; set; }
    }
}