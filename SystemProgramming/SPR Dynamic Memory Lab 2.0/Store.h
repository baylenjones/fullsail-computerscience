#pragma once
#include "Inventory.h"

class Store
{
	Inventory* m_Inventories = nullptr;
	const unsigned int m_NumInventories = 3;

public:
	Store();
	~Store();
	void Print() const;
};